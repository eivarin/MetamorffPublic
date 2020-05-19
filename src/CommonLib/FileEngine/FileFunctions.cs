    using CommonLib.FileEngine;
    using CommonLib.Models;
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Runtime.Serialization.Formatters.Binary;
    using System.Text;
    using System.Threading.Tasks;

    namespace CommonLib
    {
        public static class FileFunctions
        {
            public static bool DoesNetExist(string NetID)
            {
                //Todo: Adicionar a parte do torrent e da logica
                bool NetExist = true;
                if (FSDatabaseFunctions.GetNetModel(NetID).NetID == null)
                {
                    NetExist = false;
                }
                return NetExist;
            }
            public async static Task<byte[]> ObjectToByteArray(object obj)
            {
                if (obj == null)
                    return null;
                BinaryFormatter bf = new BinaryFormatter();
                using (MemoryStream ms = new MemoryStream())
                {
                    await Task.Run(() => bf.Serialize(ms, obj));
                    return ms.ToArray();
                }
            }
            public async static Task<List<NetModel>> ByteArrayToObject(byte[] arrBytes)
            {
                BinaryFormatter binForm = new BinaryFormatter();
                List<NetModel> obj;
                using (MemoryStream memStream = new MemoryStream())
                {
                    memStream.Write(arrBytes, 0, arrBytes.Length);
                    memStream.Seek(0, SeekOrigin.Begin);
                    obj = await Task.Run(() => (List<NetModel>)binForm.Deserialize(memStream));
                }
                return obj;
            }
        }
    }
