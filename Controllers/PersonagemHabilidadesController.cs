using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RpgApi.Data;

namespace RpgApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
        public class PersonagemHabilidadesController : ControllerBase
        {
            //Codificação geral dentro do corpo da controller.
            private readonly DataContext _contextPH;
            public PersonagemHabilidadesController(DataContext contextPH){
                _contextPH = contextPH;
            }
        }
}