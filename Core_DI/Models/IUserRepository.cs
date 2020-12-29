﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core_DI.Models
{
	public interface IUserRepository
	{
		List<User> GetAllUsers();
	}
}
