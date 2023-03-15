using eTickets.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace eTickets.Controllers
{
	public class CinemasController : Controller
	{
		private readonly AppDbContext _context;

		//Constractor
		public CinemasController(AppDbContext context)
		{
			_context = context;
		}

		//Get the data directly from the database
		public async Task<IActionResult> Index()
		{
			var AllCinemas = await _context.Cinemas.ToListAsync();
			return View(AllCinemas);
		}
	}
}
