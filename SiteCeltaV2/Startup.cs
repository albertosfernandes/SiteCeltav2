using Owin;
using SiteCeltaV2.Repositorio;
using SiteCeltaV2.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SiteCeltaV2
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.CreatePerOwinContext(Contexto.Create);
            app.CreatePerOwinContext<AppUserManager>(AppUserManager.Create);

        }
    }
}