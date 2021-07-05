using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RekenTrainer.Models
{
    public class School
    {
        [Key]
        public int Qid { get; set; }

        [DisplayName("Vraag")]
        public string Question { get; set; }

        [DisplayName("Optie 1")]
        public string Option1 { get; set; }

        [DisplayName("Optie 2")]
        public string Option2 { get; set; }

        [DisplayName("Optie 3")]
        public string Option3 { get; set; }

        [DisplayName("Optie 4")]
        public string Option4 { get; set; }

        [DisplayName("Antwoord")]
        public string Correctans { get; set; }

        [DisplayName("Categorie")]
        public string Category { get; set; }
    }
}
