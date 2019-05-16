using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Multas.Models
{
    public class Multas
    {
        public int ID { get; set; }

        [Display(Name = "Infracao")]
        public string Infracao { get; set; }

        [Display(Name ="Local da multa")]
        public string LocalDaMulta { get; set; }

        [Display(Name = "Valor da multa")]
        public decimal ValorMulta { get; set; }

        [Display(Name = "Data da multa")]
        public DateTime DataDaMulta { get; set; }

        //criar chaves forasteiras

        //FK para os agentes
        [ForeignKey("Agente")]
        public int AgenteFK { get; set; }
        public virtual Agentes Agente{ get; set; }

        //FK para o condutor
        [ForeignKey("Condutor")]
        public int CondutorFK { get; set; }
        public virtual Condutores Condutor { get; set; }

        //FK para a viatura
        [ForeignKey("Viatura")]
        public int ViaturaFK { get; set; }
        public virtual Viaturas Viatura { get; set; }

    }
}


