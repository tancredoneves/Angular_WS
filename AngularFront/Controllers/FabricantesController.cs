using System.Linq;
using System.Web.Mvc;

namespace AngularFront.Controllers
{
    public class FabricantesController : Controller
    {
        private CadastroModelo context = new CadastroModelo();
        // GET: Fabricantes
        public ActionResult Index()
        {
            return View(context.Fabricantes.OrderBy(c => c.Nome));
        }
    }
}