using eTickets.Data;
using Microsoft.AspNetCore.Mvc;

namespace eTickets.Controllers
{
	public class ActorsController : Controller
	{
		private readonly AppDbContext _context;

		//Constractor
		public ActorsController(AppDbContext context)
		{
			_context = context;
		}

		//Get the data from the DbContext
		public IActionResult Index()
		{
			var data = _context.Actors.ToList();

			return View();
		}
	}
}
