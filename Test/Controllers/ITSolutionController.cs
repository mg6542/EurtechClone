using Test.Models;
using Sitecore.Mvc.Presentation;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Sitecore.Data.Items;

namespace Test.Controllers
{
    public class ITSolutionController : Controller
    {
        // GET: ITSolution
        public ActionResult Index()
        {
            var Model = new ITSolutionModel()
            {
                Item = RenderingContext.Current?.Rendering.Item
            };
            return View(Model);
        }
        public ActionResult Index1()
        {

            var model = new HeaderModel()
            {
                Item = RenderingContext.Current?.Rendering.Item
            };
            return View("/Views/ITSolution/Index1.cshtml", model);

        }
        public ActionResult Service()
        {
            var Model = new Service()
            {

                Item = RenderingContext.Current?.Rendering.Item
            };

            return View("/Views/ITSolution/Service.cshtml", Model);
        }

        public ActionResult Testimonials()
        {
            var Model = new Testimonials()
            {

                Item = RenderingContext.Current?.Rendering.Item
            };

            return View("/Views/ITSolution/Testimonials.cshtml", Model);
        }
        public ActionResult Footer()
        {
            var Model = new FooterModel()
            {

                Item = RenderingContext.Current?.Rendering.Item
            };

            return View("/Views/ITSolution/Footer.cshtml", Model);
        }
    }

 

}