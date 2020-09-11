// endpoint	        purpose	            parameters	    return
// /Order	        Receive Mask Orders	MasksRequest	OrderNo - (Details)
// /Mask	        Get all Masks		                List of Masks in stock
// /Mask/{MaskId)	Get specific Mask   MaskId	        Mask
// /Order/{OrderId}	Check Order	        OrderNo	        Order

using Microsoft.AspNetCore.Mvc;

using System.Collections.Generic;

using MaskApi.models;
using System.Linq;

namespace MaskApi.Controllers
{
  
    [ApiController]
    [Route("[controller]")]
    public class OrderController : ControllerBase
    {
        
        public static List<Mask> MaskInStock = new List<Mask>();
        public static List<Order> Orders = new List<Order>();

        public OrderController()
        {
           
            MaskInStock.Add(new Mask("m-9999", 1, "White", true, false, "Flowers", true, 10.00));
            MaskInStock.Add(new Mask("m-8888", 3, "Black", false, true, "RaceCars", true, 3.50));
            MaskInStock.Add(new Mask("m-7777", 1, "Pink", true, false, "Peppa Pig", true, 15.00));
            MaskInStock.Add(new Mask("m-6666", 3, "Yellow", false, true, "Sponge Bob", true, 5.50));
            //create this two order in the system 
            Orders.Add(new Order(new Mask("m-9999", 1, "White", true, false, "Flowers", true, 10.00), 20));
            Orders.Add(new Order(new Mask("m-7777", 1, "Pink", true, false, "Peppa Pig", true, 15.00), 5));
        }
        

        [HttpGet("GetAll")]
        // get all order
   
        public List<Order> GetAll()
        {
            // just showing all orders to display
            return Orders;
        }
      
        // check one of the order
        [HttpGet("{orderNo}")]
        public Order GetOrder(int orderNo)
        {
           
            Order found = null;
            // foreach (var order in Orders.Where(order => orderNo == order.OrderNo))
            // {
            //     found = order;
            //     break;
            // }
             foreach (Order order in Orders)
            {
                if (orderNo == order.OrderNo)
                {
                    found = order;
                    break;
                }
            }

            return found;

           
        }

        //reviceing orders
        //just return the order no for now

        [HttpPost]
        // we need to create an another object for here
        public int MakeOrder(MaskRequest request)
        {
            // check if in stock before making order
            // the way you check if an element in an array
            // called LINQ action another way of expersion for that foreeach above
            Mask found = MaskInStock.Find(m => m.MaskId == request.MaskId);
            //return 0;

            if(found == null)
            {
                return 0;
            }

            Order newOrder = new Order(found, request.Qty);
            Orders.Add(newOrder);

            return newOrder.OrderNo;
        }
    }
}