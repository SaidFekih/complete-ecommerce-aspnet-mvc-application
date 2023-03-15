using eTickets.Data;
using eTickets.Data.Services;
using Microsoft.AspNetCore.Mvc;

namespace eTickets.Controllers
{
	public class ActorsController : Controller
	{
		private readonly IActorsService _service;

		//Constractor
		public ActorsController(IActorsService service)
		{
            _service = service;
		}

		//Get the data from the DbContext
		public async Task<IActionResult> Index()
		{
			var data = await _service.GetAll();

			return View(data);
		}
	}
}
