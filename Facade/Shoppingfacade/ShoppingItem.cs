using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shoppingfacade
{
    public class ShoppingItem
    {
        public bool AddItemToCart(string itemcode, int qty)
        {
            Stock stock = new Stock();
            stock.CheckItemItemId(itemcode);
            stock.LockItemsTemporary(itemcode, qty);

            ItemPrice item = new ItemPrice();
            item.GetItemCostByItemId(itemcode);

            Taxes tx = new Taxes();
            tx.GetStateTax("SC");
            return true;
        }
    }
}
