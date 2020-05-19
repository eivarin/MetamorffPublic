    using CommonLib.SQL;
    using MonoTorrent.Client.Tracker;
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text;
    using CommonLib.Models;

    namespace CommonLib.FileEngine
    {
        public static class FSDatabaseFunctions
        {
            public static void CreateNet(string NetID)
            {
                Querys.InsertQuery("NETS", "(NetID, TotalSize, NumberOfFiles)", "("+ NetID +", 0, 0)");
            }
            public static void UpdateNet(string NetID, Int64 TotalSize, Int64 NumberOfFiles)
            {
                Querys.UpdateQuery("NETS", "TotalSize = " + Convert.ToString(TotalSize) + ", NumberOfFiles = " + Convert.ToString(NumberOfFiles), "NetID = " + NetID);
            }
            public static NetModel GetNetModel(string NetID)
            {
                List<object> FetchedNet = Querys.SelectQuery("*", "NETS", "NetID = " + NetID).Result[0];
                NetModel FetchedNetOrg = new NetModel(Convert.ToString(FetchedNet[0]), Convert.ToInt64(FetchedNet[1]), Convert.ToInt64(FetchedNet[2]));
                return FetchedNetOrg;
            }
            public static void DeleteNet(string NetID)
            {
                CleanNetFromFiles(NetID);
                Querys.DeleteQuery("NETS", "NetID = " + NetID);
            }
            public static void CleanNetFromFiles(string NetID)
            {
                Querys.DeleteQuery("Files", "NetID" + NetID);
            }
            public static int AddFileGetFileID(string FilePath, string NetID, byte[] byteArr)
            {
                Querys.InsertQuery("Files","(VersionID, FilePath, NetID)","(1, " + FilePath + ", " + NetID + ")");
                int FileID = Convert.ToInt32(Querys.SelectQuery(NetID, "Files", "VersionID = 1 AND FilePath = " + FilePath + " AND NetID = " + NetID).Result[0][0]);
                Querys.UpdateQueryWithParams("Files", "Bytes = @Bytes", "FileID = " + Convert.ToString(FileID), "Bytes", byteArr);
                return FileID;
            }
            public static int UpdateFileGetVersionID(int FileID, byte[] NewTorrentBytes, string FilePath)
            {
                int CurrentFileVersion = Convert.ToInt32(Querys.SelectQuery("VersionID", "Files", "FileID = " + FileID).Result[0][0]);
                CurrentFileVersion-=-1;
                Querys.UpdateQueryWithParams("Files", "Bytes = @Bytes", "FileID = " + Convert.ToString(FileID), "Bytes", NewTorrentBytes);
                Querys.UpdateQuery("Files", "VersionID = " + CurrentFileVersion + ", FilePath = " + FilePath, "FileID = " + FileID);
                return CurrentFileVersion;
            }
            public static List<FileModel> GetAllFilesFromNet(string NetID)
            {
                List<List<object>> FilesUnorganized = Querys.SelectQuery("*", "Files", "NetID = " + NetID).Result;
                List<FileModel> FilesOrganized = new List<FileModel>();
                foreach (var File in FilesUnorganized)
                {
                    FilesOrganized.Add(new FileModel(Convert.ToInt32(File[0]), Convert.ToInt32(File[1]), (byte[])File[2], Convert.ToString(File[3]), Convert.ToString(File[4])));
                }
                return FilesOrganized;
            }
            public static FileModel GetOneFile(int FileID, string NetID)
            {
                List<object> FileUnorganized = Querys.SelectQuery("*", "Files", "NetID = " + NetID + " AND FileId = " + FileID).Result[0];
                FileModel FileOrganized;

                FileOrganized = new FileModel(Convert.ToInt32(FileUnorganized[0]), Convert.ToInt32(FileUnorganized[1]), (byte[])FileUnorganized[2], Convert.ToString(FileUnorganized[3]), Convert.ToString(FileUnorganized[4]));

                return FileOrganized;
            }
            public static void DeleteFile(int FileID,string NetID)
            {
                Querys.DeleteQuery("Files", "NetID = " + NetID + " AND FileID = " + FileID);
            }


        }
    }
