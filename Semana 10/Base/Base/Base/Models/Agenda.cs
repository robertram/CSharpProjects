using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace Base.Models
{
    public class Agenda
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        [MaxLength(70)]
        public String Linea { get; set; }
        [MaxLength(70)]
        public String Importancia { get; set; }
        [MaxLength(70)]
        public String Valor { get; set; }
    }
}
