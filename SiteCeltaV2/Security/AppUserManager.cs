using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin;
using SiteCeltaV2.Entities;
using SiteCeltaV2.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SiteCeltaV2.Security
{
    public class AppUserManager : UserManager<Usuario>
    {
        public AppUserManager(IUserStore<Usuario> store)
            : base(store)
        { }

        public static AppUserManager Create(IdentityFactoryOptions<AppUserManager> option, IOwinContext context)
        {
            var contexto = context.Get<Contexto>();

            var store = new UserStore<Usuario>(contexto);

            var userManager = new AppUserManager(store);

            return userManager;
        }
    }
}