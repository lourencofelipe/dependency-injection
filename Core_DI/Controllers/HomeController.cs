using Core_DI.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core_DI.Controllers
{
	public class HomeController : Controller
	{
		private readonly IUserRepository _userRepo;

		// DI by constructor.
		public HomeController(IUserRepository userRepo) 
		{
			_userRepo = userRepo;
		}

		[HttpGet]
		public IActionResult Index()
		{
			return View(_userRepo.GetAllUsers()[0]);
		}
	}
}
