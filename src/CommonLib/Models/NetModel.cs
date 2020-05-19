    using CommonLib.FileEngine;
    using System;
    using System.Collections.Generic;
    using System.Text;
    using CommonLib.MainStuff;

    namespace CommonLib.Models
    {
        [Serializable]
        public class NetModel
        {

            //Inicializador de uma nova net
            public NetModel(string NewNetID)
            {
                NetID = NewNetID;
                TotalSize = 0;
                NumberOfFiles = 0;
                Files = new List<FileModel>();
                NetID = CreateNet();
                MainProps.EvryNet.Add(this);
            }

            //Inicializador de uma net existente na base de dados para ui
            public NetModel(string NewNetID, bool ExistingNetwork)
            {
                if (ExistingNetwork)
                {
                    NetID = NewNetID;
                    //AddNet();
                    Files = FSDatabaseFunctions.GetAllFilesFromNet(NetID);
                    MainProps.EvryNet.Add(this);
                }
            }

            //Inicializador de uma net existente na base de dados para logica
            public NetModel(string NewNetID, Int64 NewTotalSize, Int64 NewNumberOfFiles)
            {
                NetID = NewNetID;
                TotalSize = NewTotalSize;
                NumberOfFiles = NewNumberOfFiles;
            }

            
            public string NetID { get; set; } = null;
            
            public Int64 TotalSize { get; set; }

            public Int64 NumberOfFiles { get; set; }

            public bool ActiveOnUI { get; set; } = false;

            [NonSerialized]
            public FolderModel NetFolder;

            public List<FileModel> Files { get; set; } = new List<FileModel>();
            
            private string CreateNet()
            {
                Random generator = new Random();
                String randomID = generator.Next(10000, 99999).ToString("D6");
                NetID = NetID + "#" + randomID;
                FSDatabaseFunctions.CreateNet(NetID);
                NetFolder = new FolderModel("\\Nets\\" + NetID);
                return NetID;
            }
            /*Funcao usada para adicionar uma net existente na base de dados*/
            private void AddNet()
            {
                NetModel novaNet = FSDatabaseFunctions.GetNetModel(NetID);
                NetID = novaNet.NetID;
                NetFolder = new FolderModel("\\Nets\\" + NetID);
                TotalSize = novaNet.TotalSize;
                NumberOfFiles = novaNet.NumberOfFiles;
            }
            public void GetEvryFileFromDB()
            {
                Files = FSDatabaseFunctions.GetAllFilesFromNet(NetID);
            }
            public void UpdateNet()
            {
                //Todo: Adicionar a parte do torrent e da logica
                FSDatabaseFunctions.UpdateNet(NetID, TotalSize, NumberOfFiles);
            }
            
            public void DeleteNet()
            {
                //Todo: Adicionar a parte do torrent e da logica
                RemoveNet();
                FSDatabaseFunctions.DeleteNet(NetID);
            }
            public void RemoveNet()
            {
                //Todo: Adicionar a parte do torrent e da logica
                
            }
        }
    }
