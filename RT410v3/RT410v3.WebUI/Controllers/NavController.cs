using System.Collections.Generic;
using System.Web.Mvc;
using RT410v3.Domain.Abstract;
using System.Linq;

namespace RT410v3.WebUI.Controllers
{
    public class NavController : Controller
    {
        private IProductRepository repository;
        // GET: Nav
        public NavController(IProductRepository repo)
        {
            repository = repo;
        }

        public PartialViewResult Menu(string category = null)
        {
            ViewBag.SelectedCategory = category;
            IEnumerable<string> categories = repository.Products
                .Select(x => x.Category)
                .Distinct()
                .OrderBy(x => x);
            return PartialView(categories);

        }
    }
}