    using MonoTorrent;
    using MonoTorrent.BEncoding;
    using MonoTorrent.TorrentWatcher;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    namespace CommonLib.TorrentStuff
    {
        public static class TCreator
        {
            public static string CreateMagnetFromFile(Torrent torrent)
            {
                var magnetLink = new MagnetLink(torrent.InfoHash, torrent.Name, torrent.AnnounceUrls.SelectMany(t => t.ToArray()).ToList());
                Uri url = magnetLink.ToV1Uri();
                string urlAsAString = magnetLink.ToV1String();
                return urlAsAString;
            }
            public static Torrent GetTorrentFromFile(string PathToFile)
            {
                TorrentCreator TC = new TorrentCreator();
                TC.Private = false;
                ITorrentFileSource filePath = new TorrentFileSource(PathToFile);
                BEncodedDictionary bed = TC.Create(filePath);
                return Torrent.Load(bed);
            }
            public static byte[] GetBytesFromFile(string PathToFile)
            {
                TorrentCreator TC = new TorrentCreator();
                TC.Private = false;
                ITorrentFileSource filePath = new TorrentFileSource(PathToFile);
                BEncodedDictionary bed = TC.Create(filePath);
                return bed.Encode();
            }
            public static Torrent GetTorrentFromByte(byte[] bytes)
            {
                BEncodedDictionary bed = BEncodedDictionary.DecodeTorrent(bytes);
                Torrent T = Torrent.Load(bed);
                return T;
            }

        }
    }
