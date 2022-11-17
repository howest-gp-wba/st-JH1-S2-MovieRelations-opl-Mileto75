using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Wba.Oefening.RateAMovie.Web.Data;
using Wba.Oefening.RateAMovie.Web.ViewModels;

namespace Wba.Oefening.RateAMovie.Web.Controllers
{
    public class CompaniesController : Controller
    {
        private readonly MovieContext _movieContext;

        public CompaniesController(MovieContext movieContext)
        {
            _movieContext = movieContext;
        }

        public IActionResult Index()
        {
            return View();
        }
        public async Task<IActionResult> Movies(int id)
        {
            var companiesMoviesViewModel = new CompaniesMoviesViewModel
            {
                Company = _movieContext.Companies.FirstOrDefault(c => c.Id == id).Name,
                Movies = _movieContext.Movies.Where(m => m.CompanyId == id)
                .Select(m => new BaseViewModel {Id = m.Id,Name = m.Title }).ToList()
            };
            return View(companiesMoviesViewModel);
        }
    }
}
