using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace TesteBancoBari.MessageBus
{
    public interface IMessageBus
    {
        void Connect();
        void Send<T>(T message);
        Task<IDisposable> RegisterReceive<T>(Action<T> lambdaAction);
    }
}
