using System;
using System.Collections.Generic;

// CREATE TABLE `roles` (
//   `id` int PRIMARY KEY,
//   `name` string
// );

namespace Models{
    public class Roles
    {
        public int id {get; set;}
        public string name {get; set;}

        public Roles(int id, string name)
        {
            this.id = id;
            this.name = name;
        }
    }
}
