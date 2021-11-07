using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FIAP.Global_ImpactWeb.Models
{   
    [Table("T_ENDERECO")]
    public class Endereco
    {
        [HiddenInput, Key]
        public int EnderecoId { get; set; }

        public string Logradouro { get; set; }

        public int Numero { get; set; }

        public string Bairro { get; set; }

        [Display(Name ="Estado")]
        public Estado Sigla { get; set; }
        
    }

    public enum Estado
    {
        AC,AL,AP,AM,BA,CE,DF,ES,GO,MA,MT,MS,MMG,PA,PB,PR,PE,PI,RR,RO,RJ,RN,RS,SC,SP,SE,TO
    }
}
