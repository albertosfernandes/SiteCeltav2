using Microsoft.AspNet.Identity.EntityFramework;
using SiteCeltaV2.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MySql.Data.MySqlClient;
using System.Data;
using System.Configuration;
using System.Data.Common;
using System.Data.Entity;
using System.Data.Entity.Migrations.History;

namespace SiteCeltaV2.Repositorio
{
    public class Contexto : IdentityDbContext<Usuario>
    {
        public Contexto()
           
        :base("dbWebCelta")
        { }
        public static Contexto Create()
        {
            return new Contexto();
        }
    }
}