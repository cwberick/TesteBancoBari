using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TesteBancoBari.Mensagem.API.Application;

namespace TesteBancoBari.Mensagem.API.Controllers
{
    [Route("api/mensagem")]
    public class MensagemController : Controller
    {

        private readonly MensagemServices _mensagemServices;

        public MensagemController(MensagemServices mensagemServices)
        {
            _mensagemServices = mensagemServices;
        }


        [Route("start")]
        public ActionResult Start()
        {
            _mensagemServices.Start();

            return Ok();
        }

    }
}
