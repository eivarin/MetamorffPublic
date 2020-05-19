    using CommonLib.Models;
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text;
    using CommonLib.TorrentStuff;

    namespace CommonLib.MainStuff
    {
        [Serializable]
        public static class MainProps
        {
            public static List<NetModel> EvryNet { get; set; } = new List<NetModel>();

            public static List<FolderModel> EvryFolder { get; set; } = new List<FolderModel>();

            public static NetModel ActiveNetOnUI { get; set; } = null;

            public async static void StartUP()
            {
                TorrentClientAPI.StartItAllV2();
                if (File.Exists(Environment.CurrentDirectory + "\\EvryNet"))
                {
                    EvryNet = await FileFunctions.ByteArrayToObject(File.ReadAllBytes(Environment.CurrentDirectory + "\\EvryNet"));
                }
                EvryFolder.Add(new FolderModel("\\Nets", true));
            }

            public static void AddNet(NetModel NewNet)
            {
                EvryNet.Add(NewNet);
            }
            
        }
    }
