using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommerce.Model
{
    public class Basket
    {
        public int BasketId { get; set; }
        public DateTime date { get; set; }

        public virtual ICollection<BasketItem> BasketItems { get; set; }

        public void createNewBasket(System.Web.HttpContextBase httpContext)
        {
            throw new NotImplementedException();
        }
    }
}
