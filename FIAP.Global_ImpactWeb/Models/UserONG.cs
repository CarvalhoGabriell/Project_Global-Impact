using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FIAP.Global_ImpactWeb.Models
{
    [Table("T_ONG")]
    public class UserONG
    {

        [HiddenInput, Key]
        public int CodigoId { get; set; }

        [Display(Name ="Nome da ONG")]
        public string Nome { get; set; }

        [Display(Name ="Breve Descrição"), MaxLength(255)]
        public string Descricao { get; set; }

        [MaxLength(14)]
        public string CNPJ { get; set; }

        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Display(Name ="lLink para o Site Oficial")]
        public string LinkSite { get; set; }

        [Display(Name ="Data Cadastro"), DataType(DataType.Date)]
        public DateTime DtCadastro { get; set; }

        public ContaBancaria Conta { get; set; }
    }
}
