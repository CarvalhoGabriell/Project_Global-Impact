using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FIAP.Global_ImpactWeb.Models
{
    [Table("T_CONTA_BANCARIA")]
    public class ContaBancaria
    {
        [HiddenInput, Key]
        public int ContaId { get; set; }

        [Display(Name ="Número da Conta")]
        public int NumeroConta { get; set; }

        [Display(Name ="Agência")]
        public int Agencia { get; set; }

        [Display(Name = "Código do Banco")]
        public string NomeBanco { get; set; }

    }
}