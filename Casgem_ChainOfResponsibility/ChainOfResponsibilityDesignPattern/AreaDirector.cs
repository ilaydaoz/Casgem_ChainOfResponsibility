using Casgem_ChainOfResponsibility.Dal;
using Casgem_ChainOfResponsibility.Models;

namespace Casgem_ChainOfResponsibility.ChainOfResponsibilityDesignPattern
{
    public class AreaDirector : Employee
    {
        public override void ProcessRequst(CostomerProcessViewModel req)
        {
            Context context = new Context();
            if (req.Amount <= 3000000)
            {
                CustomerProcess customerProcess = new CustomerProcess();
                customerProcess.Amount = req.Amount;
                customerProcess.CustomerName = req.CustomerName;
                customerProcess.EmployeeName = "Alican Özken";
                customerProcess.Description = "Müşterinin taleb ettiği tutar bölge müdürü tarafından ödendi";
                context.CustomerProcesses.Add(customerProcess);
                context.SaveChanges();
            }
            else
            {
                CustomerProcess customerProcess = new CustomerProcess();
                customerProcess.Amount = req.Amount;
                customerProcess.CustomerName = req.CustomerName;
                customerProcess.EmployeeName = "Alican Özken";
                customerProcess.Description = "Müşterinin Talep ettiği tutar günlük ödeme bakiyesi aştığı için işlem gerçekleştirilmedi";
                context.CustomerProcesses.Add(customerProcess);
                context.SaveChanges();
                NexApprover.ProcessRequst(req);
            }
        }
    }
}
