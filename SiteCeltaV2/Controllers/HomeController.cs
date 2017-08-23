using Microsoft.AspNet.Identity.Owin;
using SiteCeltaV2.Entities;
using SiteCeltaV2.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace SiteCeltaV2.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public async Task<ActionResult> Index()
        {
            Usuario user = new Usuario()
            {
                UserName = "Fabio",
                Apelido = "Administrador",
                Email = "adm@celtaware.com.br"
            };

            const string password = "Celta@123";

            var userManager = HttpContext.GetOwinContext().GetUserManager<AppUserManager>();

            var result = await userManager.CreateAsync(user, password);


            return View();
        }
    }
}