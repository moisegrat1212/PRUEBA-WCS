using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PRUEBA.Entities;
using PRUEBA.Models;

namespace PRUEBA.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SolicitudController : ControllerBase
    {
        private readonly ILogger<SolicitudController> _logger;

        public SolicitudController(ILogger<SolicitudController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public ActionResult<Object> GetSolicitudes()
        {
            BancoModel banco = new BancoModel();
            var item = banco.GetSolicitudes();
            int codRespuesta = Convert.ToInt32(item["codRespuesta"]);
            switch (codRespuesta)
            {
                case 0:
                    return (Ok(item));
                case 1:
                    return (NoContent());
                default:
                    return (BadRequest(item));
            }
        }

        [HttpPost]
        public ActionResult<Object> SendToSolicitud([FromBody] SendSolicitud sendSolicitud)
        {
            BancoModel banco = new BancoModel();
            var item = banco.SendToSolicitud(sendSolicitud);
            int codRespuesta = Convert.ToInt32(item["codRespuesta"]);
            switch (codRespuesta)
            {
                case 0:
                    return (Ok(item));
                case 1:
                    return (NoContent());
                default:
                    return (BadRequest(item));
            }
        }

            [HttpPut]
            public ActionResult<Object> UpdateSolicitud([FromBody] SendSolicitud sendSolicitud)
            {
                BancoModel banco = new BancoModel();
                var item = banco.UpdateSolicitud(sendSolicitud);
                int codRespuesta = Convert.ToInt32(item["codRespuesta"]);
                switch (codRespuesta)
                {
                    case 0:
                        return (Ok(item));
                    case 1:
                        return (NoContent());
                    default:
                        return (BadRequest(item));
                }
            }

            [HttpDelete]
            public ActionResult<Object> DeleteSolicitud([FromBody] string idSolicitud)
            {
                BancoModel banco = new BancoModel();
                var item = banco.DeleteSolicitud(idSolicitud);
                int codRespuesta = Convert.ToInt32(item["codRespuesta"]);
                switch (codRespuesta)
                {
                    case 0:
                        return (Ok(item));
                    case 1:
                        return (NoContent());
                    default:
                        return (BadRequest(item));
                }
            }
        }
    }
