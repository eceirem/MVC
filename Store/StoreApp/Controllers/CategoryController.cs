using Entities.Models;
using Microsoft.AspNetCore.Mvc;
using Repositories.Contracts;
using System.Collections.Generic;

namespace StoreApp.Controllers
{
	public class CategoryController : Controller
	{
		private IRepositoryManager _manager;
		public CategoryController(IRepositoryManager manager)
		{
			_manager = manager;
		}

		public IActionResult Index()
		{
			//IEnumerable <Category> Index(){ return _manager.Category.FindAll(false);}
			var model = _manager.Category.FindAll(false);
			return View(model);
		}

	}
}
