using System;
using System.Security.Cryptography;
using Entity;
namespace SEYNEKUN.Models
{
    public class UserInputModel 
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Estado { get; set; }
        public string NombreCompleto { get; set; }
        public string Telefono { get; set; }
        public string Token { get; set; }
    }
    public class UserViewModel : UserInputModel
     {
        public UserViewModel()
        {

        }
        public UserViewModel (User user){
         UserName=user.UserName;
         Password=user.Password;
         Estado=user.Estado;
         NombreCompleto=user.NombreCompleto;
         Telefono=user.Telefono;
     }
     }
     
}