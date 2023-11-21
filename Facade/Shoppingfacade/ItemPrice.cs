using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shoppingfacade
{
    internal class ItemPrice
    {
        public string GetItemCostByItemId(string itemID)
        {
            Console.WriteLine(string.Format("Item id:{0} cost is 35 euros", itemID));
            return "35";
        }
    }
}
