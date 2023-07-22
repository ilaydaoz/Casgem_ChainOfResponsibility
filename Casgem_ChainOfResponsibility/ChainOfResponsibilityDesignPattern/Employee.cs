using Casgem_ChainOfResponsibility.Models;

namespace Casgem_ChainOfResponsibility.ChainOfResponsibilityDesignPattern
{
    public abstract class Employee
    {
        protected Employee NexApprover;
        public void SetNextApprover (Employee Supervisor)
        {
            this.NexApprover = Supervisor;
        }
        public abstract void ProcessRequst(CostomerProcessViewModel req );
    }
}
