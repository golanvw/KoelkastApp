using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KoelkastApp.MVVM.Models
{
    [Table("Koelkasten")]
    public class Koelkast
    {
        [PrimaryKey, AutoIncrement]
        public int KoelkastId { get; set; }
        public string? KoelkastName { get; set; }
    }
}
