using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using MyRecipe.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyRecipe.Common
{
    public class JwtBearerHelper
    {
        public JwtBearerHelper(IConfiguration configuration)
        {
            _configuration = configuration;
        }

      
        private readonly IConfiguration _configuration;

        public JwtPacket CreateJwtPacket(UserModel user)
        {
           var signingKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration.GetSection("TokenSecret").Value));


            return null;

        }
    }
}
