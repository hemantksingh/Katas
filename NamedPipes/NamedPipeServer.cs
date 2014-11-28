using System;
using System.ServiceModel;

namespace NamedPipes
{
    /// <summary>
    /// Named pipes provide interprocess communication between a pipe server and one or more pipe clients. 
    /// They offer more functionality than anonymous pipes, which provide interprocess communication on a 
    /// local computer. Named pipes support full duplex communication over a network and multiple server 
    /// instances, message-based communication, and client impersonation, which enables connecting processes 
    /// to use their own set of permissions on remote servers.
    /// </summary>
    public class NamedPipeServer : IDisposable
    {
        private readonly string _documentName;
        private ServiceHost _serviceHost;

        public NamedPipeServer(string documentName)
        {
            _documentName = documentName;
            OpenNamedPipe();
        }

        private void OpenNamedPipe()
        {
            string uriString = string.Format("net.pipe://localhost/ProducingDocument/{0}/{1}", Environment.UserName,
                _documentName.ToLower());
            var wordAddIn = new Uri(uriString);
            var addinCommunicationService = new ProducingDocumentPipe();
            _serviceHost = new ServiceHost(addinCommunicationService, wordAddIn);
            _serviceHost.Open();
        }

        public void CloseNamedPipe()
        {
            _serviceHost.Close();
        }

        public void Dispose()
        {
            CloseNamedPipe();
        }
    }

    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single, UseSynchronizationContext = false)]    
    public class ProducingDocumentPipe : IProducingDocumentPipe
    {
        public bool IsProducing()
        {
            return true;
        }
    }
}