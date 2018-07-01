using System;
using System.Collections.Generic;
using System.Linq;
using System.IdentityModel.Tokens;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            var plainTextSecurityKey = "This is my shared, not so secret, secret!";
            var signingKey = new InMemorySymmetricSecurityKey(Encoding.UTF8.GetBytes(plainTextSecurityKey));
            var signingCredentials = new SigningCredentials(signingKey,
                SecurityAlgorithms.HmacSha256Signature, SecurityAlgorithms.Sha256Digest);

            //###############
//            long secondsSinceUnixEpoch = DateTimeOffset.UtcNow.ToUnixTimeSeconds();
            long secondsSinceUnixEpoch = 123456;
            string uniqueId = Guid.NewGuid().ToString();

            string tags = @"[""production"",""poweruser"",""standardadmin""]";


            var claimsIdentity = new ClaimsIdentity(new List<Claim>()
            {
                //new Claim(ClaimTypes.NameIdentifier, "myemail@myprovider.com"),
                //new Claim(ClaimTypes.Role, "Administrator"),

                //new Claim(ClaimTypes.Email, "xzy@iiii.com"),
                //new Claim(ClaimTypes.Name, "Dolly Parton"),

                new Claim("email", "xzy@iiii.com"),
                new Claim("name", "Dolly Parton"),

                new Claim("iat", secondsSinceUnixEpoch.ToString()),
                new Claim("jti", uniqueId),

                new Claim("tags", tags)




            //payload.Add("iat", secondsSinceUnixEpoch);

            //// Add JSON Web Token Id

            //payload.Add("jti", uniqueId);




        }, "Custom");

            var securityTokenDescriptor = new SecurityTokenDescriptor()
            {
          //      AppliesToAddress = "http://my.website.com",
          //      TokenIssuerName = "http://my.tokenissuer.com",
                Subject = claimsIdentity,
                SigningCredentials = signingCredentials,
            };

            var tokenHandler = new JwtSecurityTokenHandler();
            var plainToken = tokenHandler.CreateToken(securityTokenDescriptor);
            var signedAndEncodedToken = tokenHandler.WriteToken(plainToken);

            Console.WriteLine(plainToken.ToString());
            Console.WriteLine(signedAndEncodedToken);
            Console.ReadLine();

            var tokenValidationParameters = new TokenValidationParameters()
            {
                ValidAudiences = new string[]
                {
                    "http://my.website.com",
                    "http://my.otherwebsite.com"
                },
                ValidIssuers = new string[]
                {
                    "http://my.tokenissuer.com",
                    "http://my.othertokenissuer.com"
                },
                IssuerSigningKey = signingKey
            };

            SecurityToken validatedToken;
            tokenHandler.ValidateToken(signedAndEncodedToken,
                tokenValidationParameters, out validatedToken);

            Console.WriteLine(validatedToken.ToString());
            Console.ReadLine();
        }
    }
}
