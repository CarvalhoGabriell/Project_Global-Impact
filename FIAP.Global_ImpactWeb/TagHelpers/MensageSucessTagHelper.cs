using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FIAP.Global_ImpactWeb.TagHelpers
{
    public class MensageSucessTagHelper : TagHelper
    {
        public string Mensagem { get; set; }

        public string Classe { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            if(!String.IsNullOrEmpty(Mensagem))
            {
                output.TagName = "div";
                output.Attributes.SetAttribute("class", String.IsNullOrEmpty(Classe) ? "alert alert-success" : Classe);
                output.Content.SetContent(Mensagem);
            }
       
        }
    }
}
