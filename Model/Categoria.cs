using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace HortiFrutiApi.Model
{
    [Table("Categorias")]
    public class Categoria
    {
        public int Id { get; set; }

        [Column(TypeName = "VARCHAR(4)")]
        public string Apelido { get; set; }

        [MaxLength(60)]
        public string Descricao { get; set; }
    }
}
