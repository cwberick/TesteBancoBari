using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using TesteBancoBari.Mensagem.API.Domain;
using TesteBancoBari.MessageBus;

namespace TesteBancoBari.Mensagem.API.Application
{
    public class MensagemServices
    {
        private readonly IMessageBus _bus;
        private string _hostId = Guid.NewGuid().ToString().Substring(0, 5);

        public MensagemServices(IMessageBus bus)
        {
            _bus = bus;
        }

        public void Start()
        {
            RegistrarRecebimento();
            StartEnvio();
        }

        private void StartEnvio()
        {
            var DELAY = 5000; // 5s

            while (true)
            {
                var requestId = Guid.NewGuid().ToString().Substring(0, 5);
                var mensagem = new MensagemEntity(
                    _hostId, 
                    "Hello World!", 
                    DateTime.Now, 
                    requestId
                );

                _bus.Send<MensagemEntity>(mensagem);

                ImprimirMensagemEnvio(mensagem);

                Thread.Sleep(DELAY);
            }
        }

        private void RegistrarRecebimento()
        {
            _bus.RegisterReceive<MensagemEntity>(mensagem =>
            {
                ImprimirMensagemRecebimento(mensagem);
            });
        }

        private void ImprimirMensagemEnvio(MensagemEntity mensagem)
        {
            ImprimirMensagem("Send", mensagem);
        }

        private void ImprimirMensagemRecebimento(MensagemEntity mensagem)
        {
            ImprimirMensagem("Receive", mensagem);
        }

        private void ImprimirMensagem(string escopo, MensagemEntity mensagem)
        {
            Console.WriteLine($"======= Microservico ({_hostId}) - {escopo} =======");
            Console.WriteLine($"MicroservicoId: {mensagem.MicroservicoId}");
            Console.WriteLine($"Content: {mensagem.Content}");
            Console.WriteLine($"Timestamp: {mensagem.DataEnvio}");
            Console.WriteLine($"RequestId: {mensagem.RequestId}");
            Console.WriteLine($"==============================================");
            Console.WriteLine(" ");
            Console.WriteLine(" ");
        }
    }
}
