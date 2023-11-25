
using System;
using System.Collections.Generic;

namespace Models{
    public class Brand
    {
        public int id {get; set;}
        public string name {get; set;}

        public Brand(int id, string name)
        {
            this.id = id;
            this.name = name;
        }
    }
}
