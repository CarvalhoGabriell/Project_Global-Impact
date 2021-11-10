using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FIAP.Global_ImpactWeb.Models
{
    [Table("T_DOACAO")]
    public class Doacao
    {
        [HiddenInput]
        public int Id { get; set; }

        [Display(Name ="Seu Nome Completo")]
        public string NomeDoador { get; set; }

        [MaxLength(11)]
        public string CPF { get; set; }

        [Display(Name ="Email"), DataType(DataType.EmailAddress)]
        public string EmailDoador { get; set; }

        [Display(Name ="Valor da Doação")]
        public float Quantia { get; set; }

        [Display(Name ="Data da Doação")]
        public DateTime DtDoacao { get; set; }

        // relacionamento N:1
        public int? CodigoId { get; set; }

        public UserONG UserONG { get; set; }
    }
}
