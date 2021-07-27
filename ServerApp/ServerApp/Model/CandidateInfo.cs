using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ServerApp.Model
{
    public class CandidateInfo
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }

        public String ElectionName { get; set; }
        public String Name { get; set; }
        public String Symbol { get; set; }
    }
}
