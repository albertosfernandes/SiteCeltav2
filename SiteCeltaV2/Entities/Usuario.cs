using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SiteCeltaV2.Entities
{
    public class Usuario : IdentityUser
    {
        public string Apelido { get; set; }
    }
}