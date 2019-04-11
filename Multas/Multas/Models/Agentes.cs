using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Multas.Models
{
    public class Agentes
    {
        public int ID { get; set; }

        [Required(ErrorMessage ="Por favor coloque o nome")]
        [RegularExpression("([A-ZÁÉÍÓÚa-záéíóúàèìòùãõâêîôûçñ]+( |-|')?)+",ErrorMessage ="Só pode escrever letras no nome. Deve começar por uma maiuscula.")]
        public string Nome { get; set; }

        [Required(ErrorMessage ="Por favor coloque a equadra")]
        public string Esquadra { get; set; }

        public string Fotografia { get; set; }

        //identifica as multas passadas pelo agente

        public ICollection<Multas> ListaDasMultas { get; set;} 
    }
}