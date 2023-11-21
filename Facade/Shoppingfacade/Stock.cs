using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shoppingfacade
{
    internal class Stock
    {
        public bool CheckItemItemId(string itemId)
        {
            Console.WriteLine(string.Format("Item id:{0} cost is available", itemId));
            return true;
        }

        public bool LockItemsTemporary(string itemId, int qty)
        {
            Console.WriteLine(string.Format("Item id:{0} in {1} units are temporary not available", itemId, qty));
            return true;
        }

    }
}
