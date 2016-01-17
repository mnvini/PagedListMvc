using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace UsingPagedList.Models
{
    [Table("fornecedor")]
    public class Fornecedor
    {
        [Key]
        [Column("id_fornecedor")]
        public int Id { get; set; }
        [Column("nome"), MaxLength(100)]
        public string Nome { get; set; }
        [Column("cnpj"), MaxLength(14)]
        public string CNPJ { get; set; }
        [Column("email"), MaxLength(50)]
        public string Email { get; set; }
        [Column("data_cadastro")]
        public DateTime DataCadastro { get; set; }
    }
}