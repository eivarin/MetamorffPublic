
    using CommonLib.MainStuff;
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Security.Cryptography.X509Certificates;
    using System.Text;

    namespace CommonLib.Models
    {
        [Serializable]
        public class FolderModel
        {
            public string FullPath { get; set; } = null;
            public string RelativePath { get; set; } = null;

            public FolderModel RootFolder { get; set; }

            public List<FolderModel> ChildFolders { get; set; } = new List<FolderModel>();

            public List<FileModel> ChildFiles { get; set; } = new List<FileModel>();

            //Inicializador da pasta do ambiente
            public FolderModel(string FolderPath, bool IsNetsFolder=false)
            {
                FullPath = Environment.CurrentDirectory + FolderPath;
                RelativePath = FolderPath;
                String PathPastaMae = FolderPath.Remove(FolderPath.LastIndexOf('\\'));
                if (!MainProps.EvryFolder.Exists(Obj => Obj.RelativePath == PathPastaMae) && !IsNetsFolder)
                {
                    RootFolder = new FolderModel(PathPastaMae);
                    RootFolder.ChildFolders.Add(this);
                }
                else if (MainProps.EvryFolder.Exists(Obj => Obj.RelativePath == PathPastaMae) && !IsNetsFolder)
                {
                    RootFolder = MainProps.EvryFolder.Find(Obj => Obj.RelativePath == PathPastaMae);
                    RootFolder.ChildFolders.Add(this);
                }
                if (IsNetsFolder)
                {
                    RootFolder = null;
                }
                if (!Directory.Exists(FullPath))
                {
                    Directory.CreateDirectory(FullPath);
                }
                MainProps.EvryFolder.Add(this);
            }
        }
    }
