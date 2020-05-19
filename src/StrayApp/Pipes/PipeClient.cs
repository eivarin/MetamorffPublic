using System;
using System.Collections.Generic;
using System.Text;
using System.IO.Pipes;
using System.Xml.Serialization;

namespace StrayApp.Pipes
{
    public class PipeClient
    {
        private const string PipeName = "PIPE_SINGLEINSTANCEANDNAMEDPIPE";
        public NamedPipeXmlPayload _namedPipeXmlPayload;

        public PipeClient()
        {
            // We are not the first instance, send the named pipe message with our payload and stop loading
            var namedPipeXmlPayload = new NamedPipeXmlPayload
            {
                Payload = new List<string> () { "Mensagem" } 
            };

            // Send the message
            NamedPipeClientSendOptions(namedPipeXmlPayload);

            // Stop loading form and quit
            //Close();
        }

        /// <summary>
        ///     Uses a named pipe to send the currently parsed options to an already running instance.
        /// </summary>
        /// <param name="namedPipePayload"></param>
        private void NamedPipeClientSendOptions(NamedPipeXmlPayload namedPipePayload)
        {
            try
            {
                using (var namedPipeClientStream = new NamedPipeClientStream(".", PipeName, PipeDirection.Out))
                {
                    namedPipeClientStream.Connect(3000); // Maximum wait 3 seconds

                    var xmlSerializer = new XmlSerializer(typeof(NamedPipeXmlPayload));
                    xmlSerializer.Serialize(namedPipeClientStream, namedPipePayload);
                }
            }
            catch (Exception)
            {
                // Error connecting or sending
            }
        }
    }
}
