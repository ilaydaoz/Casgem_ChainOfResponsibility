using Casgem_ChainOfResponsibility.Dal;
using Casgem_ChainOfResponsibility.Models;

namespace Casgem_ChainOfResponsibility.ChainOfResponsibilityDesignPattern
{
    public class Treasurer : Employee
    {
        public override void ProcessRequst(CostomerProcessViewModel req)
        {
            Context context = new Context();
            if (req.Amount <= 50000)
            {
                CustomerProcess customerProcess = new CustomerProcess();
                customerProcess.Amount = req.Amount;
                customerProcess.CustomerName = req.CustomerName;
                customerProcess.EmployeeName = "İlayda Özken";
                customerProcess.Description = "Müşterinin taleb ettiği tutar Veznedar tarafınfan ödendi";
                context.CustomerProcesses.Add(customerProcess);
                context.SaveChanges();
            }
            else
            {
                CustomerProcess customerProcess = new CustomerProcess();
                customerProcess.Amount = req.Amount;
                customerProcess.CustomerName = req.CustomerName;
                customerProcess.EmployeeName = "İlayda Özken";
                customerProcess.Description = "Müşterinin Talep ettiği tutar Şube Müdür Yardımcsına yönlendirildi";
                context.CustomerProcesses.Add(customerProcess);
                context.SaveChanges();
                NexApprover.ProcessRequst(req);
            }
        }
    }
}