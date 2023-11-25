
// CREATE TABLE `categories` (
//   `id` int PRIMARY KEY,
//   `name` string,
//   `description` string
// );
// */

using System;
using System.Collections.Generic;
namespace Models
{
  public class Categories
  {
    public int id {get; set;}
    public string name {get; set;}
    public string description {get; set;}

    public Categories(int id, string name, string description)
    {
        this.id = id;
        this.name = name;
        this.description = description;
    }
  }
}
