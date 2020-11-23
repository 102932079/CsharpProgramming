using System;
using System.Collections.Generic;

namespace BeeKeeping
{
    public class Bee
    {
        // attributes
        public string BeeName = "Bee";
        public float BeeSize = 0.0F;



        // default constructor

        public Bee()
        {   
            // !no need
            //this.BeeName = "Bee";
            //BeeSize = 0.0F;
        }

        // variable constructor

        public Bee(string beeName, float beeSize)
        {
            this.BeeName = beeName;
            this.BeeSize = beeSize;
        }

    }
}
