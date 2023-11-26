using System;
using System.Collections.Generic;


/*
CREATE TABLE `user` (
  `id` int PRIMARY KEY,
  `email` string,
  `first_name` string,
  `last_name` string,
  `password` string,
  `address` string,
  `role` int,
  `age` Date
);
*/

namespace web.Models{
  public class User{
    public int id {get; set;}
    public string email {get; set;}
    public string first_name {get; set;}
    public string last_name {get; set;}
    public string password {get; set;}
    public string address {get; set;}
    public int role {get; set;}
    public DateTime age {get; set;}

  }
}
