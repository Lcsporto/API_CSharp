﻿using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using WFConFin.Models;

namespace WFConFin.Services
{
    public class TokenService
    {
        private readonly IConfiguration _configuration;

        public TokenService(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public string GerarToken(Usuario usuario)
        {
            var tokenHandler = new JwtSecurityTokenHandler(); // Gera o Token
            var chave = Encoding.ASCII.GetBytes(_configuration.GetSection("Chave").Get<string>()); //Transforma os dados da Chave que está no appsettings para binário

            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(
                        new Claim[] {
                            new Claim(ClaimTypes.Name, usuario.Login.ToString()),
                            new Claim(ClaimTypes.Role, usuario.Funcao.ToString()),
                        }
                ),
                Expires = DateTime.UtcNow.AddHours(2),

                SigningCredentials = new SigningCredentials(
                        new SymmetricSecurityKey(chave), SecurityAlgorithms.HmacSha256Signature
                )
            };

            var token = tokenHandler.CreateToken(tokenDescriptor);
            return tokenHandler.WriteToken(token);
        }

    }
}
