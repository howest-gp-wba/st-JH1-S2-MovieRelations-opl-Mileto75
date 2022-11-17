using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Wba.Oefening.RateAMovie.Web.Data;
using Wba.Oefening.RateAMovie.Web.ViewModels;

namespace Wba.Oefening.RateAMovie.Web.ViewComponents
{
    [ViewComponent(Name = "CompanyList")]
    public class CompanyListViewComponent : ViewComponent
    {
        private readonly MovieContext _movieContext;

        public CompanyListViewComponent(MovieContext movieContext)
        {
            _movieContext = movieContext;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var companies = await _movieContext.Companies.ToListAsync();
            //use a viewmodel
            var companiesListViewComponentViewModel = new
                CompaniesListViewComponentViewModel();
            companiesListViewComponentViewModel
                .Links = companies.Select
                (c => new BaseViewModel 
                {
                    Id = c.Id,
                    Name = c.Name,
                });
            return View(companiesListViewComponentViewModel);
        }
    }
}
