using System;
using System.Security.AccessControl;
using System.ComponentModel.DataAnnotations;//Funcionalidades extras
//Unica funcionalidade a ser usada é a chave primaria

namespace api.Models
{
    public class Pessoa
    {
        [Key]//O public int ID sera uma chave primária
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Cidade { get; set; }
        public int Idade { get; set; }
    }
}