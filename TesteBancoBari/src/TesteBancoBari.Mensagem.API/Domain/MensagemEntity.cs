using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TesteBancoBari.Mensagem.API.Domain
{
    public class MensagemEntity
    {
        public MensagemEntity(string microservicoId, string content, DateTime dataEnvio, string requestId)
        {
            MicroservicoId = microservicoId;
            Content = content;
            DataEnvio = dataEnvio;
            RequestId = requestId;
        }

        public string MicroservicoId { get; private set; }
        public string Content { get; private set; }
        public DateTime DataEnvio { get; private set; }
        public string RequestId { get; private set; }

    }
}
