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

        public async Task<IActionResult> Index()
        {
            //get the movies and put in model
            var moviesIndexViewModel = new MoviesIndexViewModel();
            moviesIndexViewModel.Movies
                = await _movieContext.Movies
                .Select(m => new BaseViewModel
                {
                    Id = m.Id,
                    Name = m.Title
                })
                .ToListAsync();
            //send to the view
            return View(moviesIndexViewModel);
        }
        
    }
}
