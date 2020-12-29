using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core_DI.Models
{
	public class UserRepository : IUserRepository
	{
		public List<User> GetAllUsers()
		{
			return new List<User>
			{
				new User()
				{
					Name = "Bruce",
					SurName = "Dickinson",
					BirthDate = new DateTime(1958, 08, 07).Date,
					UserName = "bruce"
				},
				new User()
				{
					Name = "Andre",
					SurName = "Matos",
					BirthDate = new DateTime(1971, 09, 14).Date,
					UserName = "andre"
				}
			};
		}
	}
}
