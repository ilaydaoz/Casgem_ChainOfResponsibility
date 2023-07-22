using Casgem_ChainOfResponsibility.ChainOfResponsibilityDesignPattern;
using Casgem_ChainOfResponsibility.Models;
using Microsoft.AspNetCore.Mvc;

namespace Casgem_ChainOfResponsibility.Controllers
{
    public class DefaultController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(CostomerProcessViewModel model)
        {

            Employee treasurer = new Treasurer();
            Employee managerAssinant = new ManagerAssinant();
            Employee manager = new Manager();
            Employee areaDirector = new AreaDirector();

            treasurer.SetNextApprover(managerAssinant);
            managerAssinant.SetNextApprover(manager);
            manager.SetNextApprover(areaDirector);

            treasurer.ProcessRequst(model);

            return View();
        }
    }
}
