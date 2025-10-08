using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RpgApi.Data;
using RpgApi.Models;

namespace RpgApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PersonagemHabilidadesController : ControllerBase
    {
        //Codificação geral dentro do corpo da controller.
        private readonly DataContext _contextPH;
        public PersonagemHabilidadesController(DataContext contextPH)
        {
            _contextPH = contextPH;
        }
            [HttpPost]
        public async Task<IActionResult> AddPersonagemHabilidadeAsync(PersonagemHabilidade novoPersonagemHabilidade) {
            try {
                Personagem personagem = await _contextPH.TB_PERSONAGENS.Include(p => p.Arma)
                .Include(p => p.PersonagemHabilidades).ThenInclude(ps => ps.Habilidade)
                .FirstOrDefaultAsync(p => p.Id == novoPersonagemHabilidade.PersonagemId);

                if (personagem == null)
                    throw new System.Exception("Personagem não para o Id informado.");

                Habilidade habilidade = await _contextPH.TB_HABILIDADES
                    .FirstOrDefaultAsync(h => h.Id == novoPersonagemHabilidade.HabilidadeId);

                if (personagem == null)
                    throw new System.Exception("Habildade não encontrada. ");

                PersonagemHabilidade ph = new PersonagemHabilidade();
                ph.Personagem = personagem;
                ph.Habilidade = habilidade;
                await _contextPH.TB_PERSONAGENS_HABILIDADES.AddAsync(ph);
                int linhasAfetadas = await _contextPH.SaveChangesAsync();
                return Ok(linhasAfetadas);


            }
            catch (System.Exception ex) {
                return BadRequest(ex.Message);

            }
        }
    }


    }
