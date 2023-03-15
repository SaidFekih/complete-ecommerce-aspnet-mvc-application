using eTickets.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace eTickets.Controllers
{
	public class MoviesController : Controller
	{
		private readonly AppDbContext _context;

		//Constractor
		public MoviesController(AppDbContext context)
		{
			_context = context;
		}

		//Get the data directly from the database
		public async Task<IActionResult> Index()
		{
			var AllMovies = await _context.Movies.ToListAsync();
			return View();
		}
	}
}
