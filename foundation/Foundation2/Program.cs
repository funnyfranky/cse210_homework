using System;
using Foundation2;

class Program
{
    static void Main(string[] args)
    {
        Customer person1 = new("Sherri","Anywhere Ln.","Ogden","Utah","USA");

        Order order1 = new(person1);
        order1.AddToOrder("Bag of Grapes",1,3.99,1);
        order1.AddToOrder("Corn Dogs",2,8.99,2);
        order1.AddToOrder("Cheese - Block",3,5.98,1);
        order1.PrintPackingLabel();
        order1.PrintShippingLabel();

        Customer person2 = new("Yoshi","2 N Rain Road","Calgary","Alberta","CA");
        Order order2 = new(person2);
        order2.AddToOrder("TV",4,649.99,1);
        order2.AddToOrder("Graham Crackers",5,1.98,2);
        order2.PrintPackingLabel();
        order2.PrintShippingLabel();

        
    }
}