using EasyNetQ;
using System;
using System.Threading.Tasks;

namespace TesteBancoBari.MessageBus
{
    public class MessageBus : IMessageBus
    {
        private IBus _bus;
        private readonly string _connetionString;
        private readonly string _queue;
        public MessageBus(string connetionString)
        {
            _queue = "BancoBari.queue";
            _connetionString = connetionString;
        }

        public void Connect()
        {
            try
            {
                if (_bus == null || !_bus.Advanced.IsConnected)
                    _bus = RabbitHutch.CreateBus(_connetionString);
            }
            catch
            {
                throw;
            }
        }

        public async Task<IDisposable> RegisterReceive<T>(Action<T> lambdaAction)
        {
            Connect();
            return await _bus.SendReceive.ReceiveAsync<T>(_queue, lambdaAction);
        }

        public async void Send<T>(T message)
        {
            Connect();
            await _bus.SendReceive.SendAsync<T>(_queue, message);
        }
    }
}
