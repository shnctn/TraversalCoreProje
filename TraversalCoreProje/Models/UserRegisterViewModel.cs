using System.ComponentModel.DataAnnotations;

namespace TraversalCoreProje.Models
{
	public class UserRegisterViewModel
	{
		[Required(ErrorMessage ="Lütfen Adınız yazınız")]
		public string name { get; set; }
		[Required(ErrorMessage ="Lütfen soyadınız yazınız")]
		public string surname { get; set; }
		
		[Required(ErrorMessage = "Lütfen kullanıcıAdınız yazınız")]
		public string username { get; set; }

		[Required(ErrorMessage ="Lütfen  mail yazınız")]
		public string mail { get; set; }

		[Required(ErrorMessage ="Lütfen şifre yazınız")]
		public string password { get; set; }

		[Required(ErrorMessage ="Lütfen şifreyi dogrulayınız")]
		[Compare("password",ErrorMessage ="şifreler uyumlu değil")]
		public string confirmpassword { get; set; }
		
	}
}
