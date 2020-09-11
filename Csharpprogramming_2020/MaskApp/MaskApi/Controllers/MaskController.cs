// endpoint	        purpose	            parameters	    return
// /Order	        Receive Mask Orders	MasksRequest	OrderNo - (Details)
// /Mask	        Get all Masks		                List of Masks in stock
// /Mask/{MaskId)	Get specific Mask   MaskId	        Mask
// /Order/{OrderId}	Check Order	        OrderNo	        Order

using Microsoft.AspNetCore.Mvc;
//above using is for json
// create csharp class in controller for a new controller
using System.Collections.Generic;
// for array list
using MaskApi.models;
// for referencing mask class
namespace MaskApi.Controllers
{
    //defalut item
    [ApiController]
    [Route("[controller]")]
    public class MaskController : ControllerBase
    {
        //check the plan above
        // we also need to reference mask for able to use mask class here see top with using
        public static List<Mask> MaskInStock = new List<Mask>();

        public MaskController()
        {
            // Maskinstock is array list using add to insert data
            MaskInStock.Add(new Mask("m-9999", 1, "White", true, false, "Flowers", true, 10.00));
            MaskInStock.Add(new Mask("m-8888", 3, "Black", false, true, "RaceCars", true, 3.50));
            MaskInStock.Add(new Mask("m-7777", 1, "Pink", true, false, "Peppa Pig", true, 15.00));
            MaskInStock.Add(new Mask("m-6666", 3, "Yellow", false, true, "Sponge Bob", true, 5.50));
        }
        

        [HttpGet("GetAll")]
        //what to return
        //Get all Masks its a get
        public List<Mask> GetAll()
        {
            return MaskInStock;
        }
        //Get specific Mask its a get
        //the maskID using {} beacuse is a variable ?
        // {maskId} maps to get mask string maskId
        [HttpGet("{maskId}")]
        public Mask GetMask(string maskId)
        {
            //The foreach Loop There is also a foreach loop, which is used exclusively to loop through elements in an array
            Mask found = null;
            foreach (Mask mask in MaskInStock)
            {
                if (maskId == mask.MaskId)
                {
                    found = mask;
                    break;
                }
            }
            return found;

            // after this we need to run the project
            // dotnet run --project url maskapi/maskapi.csproj

        }
    }
}