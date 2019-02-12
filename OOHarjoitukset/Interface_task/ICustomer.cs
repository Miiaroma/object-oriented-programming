using System;
using System.Collections.Generic;
using System.Text;

namespace Interface_task
{
    interface ICustomer
    {
        Customer GetCustomer(string cName);

        double GetBonus();
    }
}
