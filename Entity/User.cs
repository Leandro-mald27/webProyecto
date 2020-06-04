using System.ComponentModel.DataAnnotations;
using System;
namespace Entity
{
    public class User
    {
        [Key]
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Estado { get; set; }
        public string NombreCompleto { get; set; }
        public string Telefono { get; set; }
    }
}