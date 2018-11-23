using System.ComponentModel.DataAnnotations;

namespace Hyhrobot.WebManagement.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}