using System;
using System.Collections.Generic;
using System.Text;

namespace Interface_task
{
    interface IProduct
    {
        Product GetProduct(string name);

        double CalculateTotal();
    }
}
