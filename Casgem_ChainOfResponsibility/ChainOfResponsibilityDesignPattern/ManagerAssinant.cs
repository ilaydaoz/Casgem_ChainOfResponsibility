using Casgem_ChainOfResponsibility.Dal;
using Casgem_ChainOfResponsibility.Models;

namespace Casgem_ChainOfResponsibility.ChainOfResponsibilityDesignPattern
{
    public class ManagerAssinant : Employee
    {
        public override void ProcessRequst(CostomerProcessViewModel req)
        {
          Context context = new Context();
            if (req.Amount <= 10000)
            {
                CustomerProcess customerProcess = new CustomerProcess();    
                customerProcess.Amount = req.Amount;
                customerProcess.CustomerName = req.CustomerName;
                customerProcess.EmployeeName = "sümeyye sabırlı";
                customerProcess.Description = "Müşterinin taleb ettiği tutar Şube müdürü tarafından ödendi";
                context.CustomerProcesses.Add(customerProcess);
                context.SaveChanges();
            }
            else
            {
                CustomerProcess customerProcess = new CustomerProcess();
                customerProcess.Amount = req.Amount;
                customerProcess.CustomerName = req.CustomerName;
                customerProcess.EmployeeName = "sümeyye sabırlı";
                customerProcess.Description = "Müşterinin Talep ettiği tutar günlük bakiye aştığı için şube müdürüne yönlendirildi";
                context.CustomerProcesses.Add(customerProcess);
                context.SaveChanges();
                NexApprover.ProcessRequst(req);
            }
        }
    }
}
