using System.ComponentModel.DataAnnotations;

namespace Loginpagegit.Dto
{
    public sealed class LoginRequestDto
    {
       [StringLength(maximumLength:200, MinimumLength = 3)]

       
       public string Username { get; set; } = string.Empty;

      
       public string Email { get; set; } = string.Empty ;
    }
}
