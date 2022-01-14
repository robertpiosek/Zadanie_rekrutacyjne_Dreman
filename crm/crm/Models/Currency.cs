using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;


namespace crm.Models
{
    public class Currency
    {
        [Key]
        public int id { get; set; }

        [Column(TypeName = "nvarchar(1)")]
        public string symbol { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public string name { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        public double rate { get; set; }

        [Column(TypeName = "nvarchar(10)")]
        public bool is_sync { get; set; } = false;

        [Column(TypeName = "nvarchar(50)")]
        public DateTime created_at { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        public DateTime updated_at { get; set; }

        [Column(TypeName = "nvarchar(10)")]
        public bool ghosted { get; set; } = false;
    }
}
