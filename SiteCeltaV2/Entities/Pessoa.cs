using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace SiteCeltaV2.Entities
{
    public class Pessoa
    {
        public int Id {get;set;}

        [Required(ErrorMessage ="Nome da pessoa obrigatório")]
        public string Nome { get; set; }
    }
}