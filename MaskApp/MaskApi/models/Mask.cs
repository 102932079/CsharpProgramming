// Mask:
// 	MaskID: string (of format m-dddd)				m-9999
// Size: int (1-small, 2-med, 3-lar)					1
// 	Colour: string								White
// 	New: bool 									True
// 	Pre-infected: bool							False
// 	Design: string								Flowers
// 	Reusable: bool								True
// Cost: double (rounded to two decimal places)		10.00

namespace MaskApi.models
{
    public class Mask
    {
        

        // shortcut for creating properies (prop)
        public string MaskId { get; set; }
        public int Size { get; set; }
        public string Colour { get; set; }
        public bool New { get; set; }
        public bool PreInfected { get; set; }
        public string Design { get; set; }
        public bool Reusable { get; set; }
        public double Cost { get; set; }

        // always left constructorbelow the atrridute 
        // there are two type of constructor
        // one is defalut empty constructor another one is for pass in value for parameter
        // why @new not just new in parameter beacuse new reserved , has been used somewhere else
        public Mask(string maskId, int size, string colour, bool @new, bool preInfected, string design, bool reusable, double cost)
        {
            this.MaskId = maskId;
            this.Size = size;
            this.Colour = colour;
            this.New = @new;
            this.PreInfected = preInfected;
            this.Design = design;
            this.Reusable = reusable;
            this.Cost = cost;
        }
    }
}