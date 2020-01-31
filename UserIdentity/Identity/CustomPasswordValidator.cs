using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace UserIdentity.Identity
{
    public class CustomPasswordValidator:PasswordValidator
    {
        //Bu class'ın içerisine CustomPasswordValidator'de tanımlanan özellikler dışında 
        //ekstra özellikler tanımlayabiliriz
        public override async Task<IdentityResult> ValidateAsync(string password)
        {
            var result = await base.ValidateAsync(password);
            if (password.Contains("12345"))
            {
                var errors = result.Errors.ToList();
                errors.Add("Parola ardışık sayısal ifade içerremez");
                result = new IdentityResult(errors);
            }
            return result;
        }
    }
}