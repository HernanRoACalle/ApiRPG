using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RpgApi.Data;
using RpgApi.Models;
using RpgApi.Utils;

namespace RpgApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsuariosController : ControllerBase
    {
        private readonly DataContext _contextUsuario;
        public UsuariosController(DataContext contextUsuarios){
            _contextUsuario = contextUsuarios;
        }

        private async Task<bool> UsuarioExistente(string Username){
            if (await _contextUsuario.TB_USUARIOS.AnyAsync(x => x.Username.ToLower() == Username.ToLower())){
                return true;
            }
            return false;
        }
        [HttpPost("Registrar")]
        public async Task<IActionResult> RegistrarUsuario(Usuarios User){
            try{
                if (await UsuarioExistente(User.Username))
                    throw new System.Exception("Nome do Usuario ja existe");
                Criptografia.CriarPasswordHash(User.PasswordString,out byte[] hash,out byte[] salt);
                User.PasswordString = string.Empty;
                User.PasswordHash = hash;    
                User.PasswordSalt = salt;
                await _contextUsuario.TB_USUARIOS.AddAsync(User);
                await _contextUsuario.SaveChangesAsync();

                return Ok(User.Id);   
            }
            catch(System.Exception ex){
                return BadRequest(ex.Message);
            }
        }
        [HttpPost("Autenticar")]
        public async Task<IActionResult> AutenticarUsuario(Usuarios credenciais){
            try{
                Usuarios? usuarios = await _contextUsuario.TB_USUARIOS.FirstOrDefaultAsync(x => x.Username.ToLower().Equals(credenciais.Username.ToLower()));
                if(usuarios == null){
                    throw new System.Exception("Usuario não encontrado");
                }
                else if(!Criptografia.VerificarPasswordHash(credenciais.PasswordString, usuarios.PasswordHash, usuarios.PasswordSalt )){
                    throw new System.Exception("Senha incorreta.");
                }
                else {
                    return Ok(usuarios);
                }
            }
            catch (System.Exception ex){
                return BadRequest(ex.Message);
            }
        }
    
    }

}