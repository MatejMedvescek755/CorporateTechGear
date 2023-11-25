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

namespace Models{
  public class User{
    public int id {get; set;}
    public string email {get; set;}
    public string first_name {get; set;}
    public string last_name {get; set;}
    public string password {get; set;}
    public string address {get; set;}
    public int role {get; set;}
    public DateTime age {get; set;}

    public User(int id, string email, string first_name, string last_name, string password, string address, int role, DateTime age)
    {
        this.id = id;
        this.email = email;
        this.first_name = first_name;
        this.last_name = last_name;
        this.password = password;
        this.address = address;
        this.role = role;
        this.age = age;
    }
  }
}
