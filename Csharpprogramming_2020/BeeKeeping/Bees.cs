using System;
using System.Collections.Generic;

namespace BeeKeeping
{
    public class Bee
    {
        // attributes
        public string BeeName;
        public float BeeSize;

        // default constructor

        public Bee()
        {
            this.BeeName = "Bee";
            this.BeeSize = 0.0F;
        }

        // variable constructor

        public Bee(string beeName, float beeSize)
        {
            this.BeeName = beeName;
            this.BeeSize = beeSize;
        }

    }
}
