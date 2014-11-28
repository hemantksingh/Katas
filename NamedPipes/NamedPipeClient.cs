using System;
using System.ServiceModel;

namespace NamedPipes
{
    public class NamedPipeClient
    {
        private readonly ChannelFactory<IProducingDocumentPipe> _channelFactory;

        public NamedPipeClient(string documentName)
        {
            string uriString = string.Format("net.pipe://localhost/ProducingDocument/{0}/{1}", Environment.UserName,
                documentName.ToLower());
            _channelFactory = new ChannelFactory<IProducingDocumentPipe>(new NetNamedPipeBinding(), uriString);
        }

        public bool IsProducing()
        {
            try
            {
                _channelFactory.Open();
                IProducingDocumentPipe channel = _channelFactory.CreateChannel();
                return channel.IsProducing();
            }
            catch (EndpointNotFoundException)
            {
                _channelFactory.Abort();
                return false;
            }
            finally
            {
                _channelFactory.Close();
            }
        }
    }

    [ServiceContract]
    public interface IProducingDocumentPipe
    {
        [OperationContract]
        bool IsProducing();
    }
}