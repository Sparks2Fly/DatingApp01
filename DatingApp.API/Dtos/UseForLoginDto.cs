using System.ComponentModel.DataAnnotations;

namespace DatingApp.API.Dtos
{
    public class UseForLoginDto
    {
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}