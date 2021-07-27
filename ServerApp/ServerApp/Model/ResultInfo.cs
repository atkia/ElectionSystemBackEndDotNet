using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ServerApp.Model
{
    public class ResultInfo
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }

        public String CandidateName { get; set; }
        public String Symbol { get; set; }
        public int Count { get; set; }
    }
}
