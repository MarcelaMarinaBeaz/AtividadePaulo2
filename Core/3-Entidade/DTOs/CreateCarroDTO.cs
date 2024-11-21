using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core._3_Entidade.DTOs
{
    [Table("Carros")]
    public class CreateCarroDTO
    {
        public int Id { get; set; }
        public string Tipo { get; set; }
        public int AutomovelId { get; set; }
    }
}
