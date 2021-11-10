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

        [Display(Name ="Link para o Site Oficial"), DataType(DataType.Url)]
        public string LinkSite { get; set; }

        [Display(Name ="Data Cadastro"), DataType(DataType.Date)]
        public DateTime DtCadastro { get; set; }

        // relacionamento 1:1
        public ContaBancaria Conta { get; set; }

        public int ContaId { get; set; }

        // relacionamento 1:1
        public Endereco Endereco { get; set; }

        public int EnderecoId { get; set; }

        // relacionamento 1:N
        public virtual ICollection<UserONG> ONGs { get; set; }
    }
}
