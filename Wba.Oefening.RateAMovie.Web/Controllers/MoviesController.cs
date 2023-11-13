using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Wba.Oefening.RateAMovie.Web.Data;
using Wba.Oefening.RateAMovie.Web.ViewModels;

namespace Wba.Oefening.RateAMovie.Web.Controllers
{
    public class MoviesController : Controller
    {
        private readonly MovieContext _movieContext;

        public MoviesController(MovieContext movieContext)
        {
            _movieContext = movieContext;
        }

        [HttpGet]
        public IActionResult Index()
        {
            //get the movies and fill the model
            var moviesIndexViewModel
                = new MoviesIndexViewModel
                {
                    Movies = _movieContext
                    .Movies
                    .Include(m => m.Directors)
                    .Select(m => new MovieBaseViewModel
                    {
                        Id = m.Id,
                        Value = m.Title,
                        Directors = m.Directors.Select
                        (d => new BaseViewModel { Id = d.Id,Value = $"{d.FirstName} {d.LastName}"})
                    })
                };
            return View(moviesIndexViewModel);
        }
    }
}
