using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KoelkastApp.MVVM.Models
{
    [Table("Products")]
    public class Product
    {
        
        [PrimaryKey, AutoIncrement]
        public int ProductId { get; set; }
        public string? ProductName { get; set; }
        public float ? Price { get; set; }
        public int Minimum { get; set; }
        public int ? CategoryId { get; set; }
    }
}
