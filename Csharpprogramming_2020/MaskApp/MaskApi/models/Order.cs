// Order:
// 	OrderNo: int (1000 or greater)
// 	Qty: int	
// 	mask: Mask
// 	Price: double (rounded to two decimal places)

using System;
using MaskApi;

namespace MaskApi.models
{
    public class Order
    {
        

        public int OrderNo { get; set; }
        public int Qty { get; set; }
        public Mask mask { get; set; }
        public double Price { get; set; }

        //constructor we can just using lightbulb for quick build ctor
        
        // no need order and price
        //public Order(int orderNo, int qty, Mask mask, double price)
        public Order( int qty, Mask mask)
        {
            // dont need this keyword for csharp
            //this.OrderNo = orderNo;
            this.OrderNo = this.GenOrderNo();
            this.Qty = qty;
            this.Mask = mask;
            //this.Price = price;
            // the setprice method return type is void
            // so set price to setprice to nothing is not making sense
            //this.Price = this.SetPrice();
            // if we are not change anything for method stay in void
            // we can just call it here in attribute
            // ignor above code and us
            this.SetPrice();
        }

        //method to calculate price
        public void SetPrice()
        {
            this.Price = this.Qty * Mask.Cost;
        }
        // make this method to double
        // public double SetPrice()
        // {
        //     return this.Qty * Mask.Cost;
        // }

        public int GenOrderNo()
        {
            // random libiry
            Random rand = new Random();
            return rand.Next(1000, 10000);
            

        }
        
    }
}