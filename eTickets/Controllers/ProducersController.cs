using eTickets.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace eTickets.Controllers
{
	public class ProducersController : Controller
	{
		private readonly AppDbContext _context;

		//Constractor
		public ProducersController(AppDbContext context)
		{
			_context = context;
		}

		//Get the data directly from the database
		public async Task<IActionResult> Index()
		{
			var allProducers = await _context.Producers.ToListAsync();
			return View();
		}
	}
}
