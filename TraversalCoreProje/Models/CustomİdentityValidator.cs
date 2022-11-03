using Microsoft.AspNetCore.Identity;

namespace TraversalCoreProje.Models
{
	public class CustomİdentityValidator:IdentityErrorDescriber
	{
		public override IdentityError PasswordTooShort(int length)
		{
			return new IdentityError() { 
				Code = "PasswordTooShort", 
				Description = $"Parola minimum{length} karakter olmalıdır." 
			};
		}
		public override IdentityError PasswordRequiresUpper()
		{
			return new IdentityError()
			{
				Code = "PasswordRequiresUpper",
				Description = "En az 1 büyük harf içermelidir."
			};
		}
        public override IdentityError PasswordRequiresLower()
        {
            return new IdentityError()
            {
                Code = "PasswordRequiresLower",
                Description = "En az 1 küçük harf içermelidir."
            };
        }
		public override IdentityError PasswordRequiresNonAlphanumeric()
		{
		    return new IdentityError()
            {
                Code = "PasswordRequiresNonAlphanumeric",
                Description = "En az 1 sembol harf içermelidir."
            };
        }
    }
}
