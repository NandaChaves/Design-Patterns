using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shoppingfacade
{
    internal class Taxes
    {
        public string GetStateTax(string statecode)
        {
            return (string.Format("{0} state tax is 6% ", statecode));
            
        }
    }
}
