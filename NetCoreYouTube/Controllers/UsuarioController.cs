using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.JsonWebTokens;
//using Microsoft.IdentityModel.Tokens;
//using NetCoreYouTube.Models;
//using Newtonsoft.Json;
//using System.IdentityModel.Tokens.Jwt;
//using System.Security.Claims;
//using System.Text;
//using JwtRegisteredClaimNames = Microsoft.IdentityModel.JsonWebTokens.JwtRegisteredClaimNames;

//namespace NetCoreYouTube.Controllers
//{
//    [Route("api/[controller]")]
//    [ApiController]
//    public class UsuarioController : ControllerBase
//    {
//        public IConfiguration _configuration;

//        public UsuarioController(IConfiguration configuration)
//        {
//            _configuration = configuration;
//        }

//        public dynamic IniciarSesion([FromBody]  Object optData) 
//        { 
        
//            var data = JsonConvert.DeserializeObject<dynamic>(optData.ToString());

//            var user = data.User.ToString();
//            var password = data.Password.ToString();

//            Usuario  usuario = Usuario.DB().Where(x => x.User && x.Password == password).FirstOrDefault();

//            if (usuario == null)
//            {

//                return new
//                {
//                    success = false,
//                    message = "Credenciales no validas",
//                    result = "",
//                };

//                var jwt = _configuration.GetSection("Jwt").Get<Jwt>();

//                var claims = new[]
//                {
//                    new Claim(JwtRegisteredClaimNames.Sub, jwt.Subject),
//                    new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
//                    new Claim(JwtRegisteredClaimNames.Iat, DateTime.UtcNow.ToString()),
//                    new Claim("id", usuario.IdUser),
//                    new Claim("usuario", usuario.User)
//                };

//                var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(jwt.Key));
//                var singIn = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

//                var token = new JwtSecurityToken (
                        
//                    jwt.Issuer,
//                    jwt.Audience,
//                    claims,
//                    expires: DateTime.Now.AddMinutes(4),
//                    signingCredentials: singIn


//                    );
//                return new
//                {
//                    success = true,
//                    message = "exito",
//                    result = new JwtSecurityTokenHandler().WriteToken(token)
//                };
                
//            }
//        }
//    }
//}
