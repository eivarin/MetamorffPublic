    using MonoTorrent;
    using MonoTorrent.Client;
    using System;
    using System.Collections.Generic;
    using System.Text;
    using CommonLib.TorrentStuff;
    using System.IO;
    using System.Data.SqlClient;
    using CommonLib.SQL;
    using CommonLib.FileEngine;
    using CommonLib.MainStuff;
    using MonoTorrent.BEncoding;
    using System.Threading.Tasks;
    using System.Security.Cryptography.X509Certificates;

    namespace CommonLib.Models
    {
        [Serializable]
        public class FileModel
        {
            //Inicializar ficheiro a partir de um ficheiro na base de dados
            public FileModel(int NewFileID, int NewFileVersion, byte[] TorrentBytes, string NewFilePath, string NewNetID, bool NewWillDownload = false)
            {
                FileID = NewFileID;
                FileVersion = NewFileVersion;
                FileName = NewFilePath.Substring(NewFilePath.LastIndexOf('\\') + 1);
                String PathPastaMae = NewFilePath.Remove(NewFilePath.LastIndexOf('\\'));
                if (!MainProps.EvryFolder.Exists(Obj => Obj.RelativePath == PathPastaMae))
                {
                    PastaRoot = new FolderModel(PathPastaMae);
                }
                else
                {
                    PastaRoot = MainProps.EvryFolder.Find(Obj => Obj.RelativePath == PathPastaMae);
                }
                Tmanager = new TorrentManager(TCreator.GetTorrentFromByte(TorrentBytes), Environment.CurrentDirectory + PathPastaMae + "\\"); ;
                FilePath = NewFilePath;
                NetID = NewNetID;
                WillDownload = NewWillDownload;
                ToggleWillDownload();
                DEP = new SqlDependency(new SqlCommand("Select * FROM Files WHERE FileId = " + FileID, ConnectionStuff.con));
                DEP.OnChange += new OnChangeEventHandler(FileChangedRemotelyEH);
                PastaRoot.ChildFiles.Add(this);
            }

            //Inicializar um ficheiro a partir de um ficheiro local
            public FileModel(string NewFilePath, string OldFilePath, string NewNetID, bool NewWillDownload = true)
            {
                FileVersion = 1;
                FileName = NewFilePath.Substring(NewFilePath.LastIndexOf('\\') + 1);
                String PathPastaMae = NewFilePath.Remove(NewFilePath.LastIndexOf('\\'));
                if (!MainProps.EvryFolder.Exists(Obj => Obj.RelativePath == PathPastaMae))
                {
                    PastaRoot = new FolderModel(PathPastaMae);
                }
                else
                {
                    PastaRoot = MainProps.EvryFolder.Find(Obj => Obj.RelativePath == PathPastaMae);
                }
                if (File.Exists(OldFilePath))
                {
                    File.Move(OldFilePath, Environment.CurrentDirectory + NewFilePath);
                }
                FilePath = NewFilePath;
                byte[] bytes = TCreator.GetBytesFromFile(NewFilePath);
                Torrent torrent = TCreator.GetTorrentFromByte(bytes);
                if (TorrentClientAPI.fastResume.ContainsKey(torrent.InfoHash.ToHex()))
                {
                    Tmanager.LoadFastResume(new FastResume((BEncodedDictionary)TorrentClientAPI.fastResume[torrent.InfoHash.ToHex()]));
                }
                else
                {
                    Tmanager = new TorrentManager(torrent, Environment.CurrentDirectory);
                }
                NetID = NewNetID;
                WillDownload = NewWillDownload;
                FileID = FSDatabaseFunctions.AddFileGetFileID(FilePath, NetID, bytes);
                ToggleWillDownload();
                DEP = new SqlDependency(new SqlCommand("Select * FROM Files WHERE FileID = " + FileID, ConnectionStuff.con));
                DEP.OnChange += new OnChangeEventHandler(FileChangedRemotelyEH);
                PastaRoot.ChildFiles.Add(this);
            }

            private void FileChangedRemotelyEH(object o, SqlNotificationEventArgs e)
            {
                GetUpdatedFile();
            }

            private async void GetUpdatedFile()
            {
                //preciso de arranjar maneira de mudar o caminho do ficheiro
                await Tmanager.StopAsync();
                await TorrentClientAPI.engine.Unregister(Tmanager);
                Tmanager.Dispose();
                PastaRoot.ChildFiles.Remove(this);
                File.Delete(Environment.CurrentDirectory + FilePath);
                FileModel NewFile = FSDatabaseFunctions.GetOneFile(FileID, NetID);
                FileVersion = NewFile.FileVersion;
                Tmanager = NewFile.Tmanager;
                FilePath = NewFile.FilePath;
                ToggleWillDownload();
                DEP = new SqlDependency(new SqlCommand("Select * FROM Files WHERE FileID = " + FileID, ConnectionStuff.con));
                DEP.OnChange += new OnChangeEventHandler(FileChangedRemotelyEH);
                PastaRoot.ChildFiles.Add(this);
            }

            public int FileID { get; set; }

            public string FileName { get; set; }

            public int FileVersion { get; set; } = 1;

            public string NetID { get; set; }

            public long Tamanho { get; set; }
            /*O tamanho tem que ser long*/
            public DateTime DataDeModificacao { get; set; }
            /*A data tem que ser datetime*/

            public string FilePath { get; set; }


            public FolderModel PastaRoot { get; set; }

            public bool WillDownload { get; set; } = false;

            [NonSerialized]
            public TorrentManager Tmanager;

            [NonSerialized]
            private SqlDependency DEP = null;

            private async void ToggleWillDownload()
            {
                if (WillDownload == true)
                {
                    await TorrentClientAPI.engine.Register(Tmanager);
                    await Tmanager.StartAsync();
                    
                }
                else
                {
                    try
                    {
                        await Tmanager.StopAsync();
                        await TorrentClientAPI.engine.Unregister(Tmanager);
                    }
                    catch (Exception)
                    {
                    }
                }
            }
        }
    }
