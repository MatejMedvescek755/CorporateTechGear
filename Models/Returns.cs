using System;
using System.Collections.Generic;

namespace Models{
    public class Returns
    {
        public int id {get; set;}
        public int order_id {get; set;}

        public Returns(int id, int order_id)
        {
            this.id = id;
            this.order_id = order_id;
        }
    }
}

// CREATE TABLE `returns` (
//   `id` int PRIMARY KEY,
//   `order_id` int
// );
