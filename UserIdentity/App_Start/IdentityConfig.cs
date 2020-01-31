using System;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.Owin;
using Microsoft.Owin.Security.Cookies;
using Owin;

[assembly: OwinStartup(typeof(UserIdentity.IdentityConfig))]

namespace UserIdentity
{
    public class IdentityConfig
    {
        public void Configuration(IAppBuilder app)
        {
            // Uygulamanızı nasıl yapılandıracağınız hakkında daha fazla bilgi için https://go.microsoft.com/fwlink/?LinkId=316888 adresini ziyaret edin
            app.UseCookieAuthentication(new CookieAuthenticationOptions
            {
                AuthenticationType=DefaultAuthenticationTypes.ApplicationCookie,
                LoginPath = new PathString("/Account/Login") //owin login işlemlerini nasıl yapacağımız hakkında işlemleri ayarlar
                //gitmek istediğimiz sayfa için iznimiz olmadığında bizi /Account/Login'e yönlendirecek
            });
        }
    }
}
