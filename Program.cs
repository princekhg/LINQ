using System;
using System.Collections.Generic;
using System.Linq;
class LINQ
{
    string[] names;
    public void read()
    {
        int n;
        Console.WriteLine("Enter total numbers names you want to enter");
        n=Convert.ToInt32(Console.ReadLine());
        names=new string[n];
        for(int i=0;i<n;i++)
            names[i]=Console.ReadLine();    
    }

    public void display()
    {
        var query = from name in names
                    orderby name descending
                    select name;
        foreach(var item in query)
            Console.WriteLine(item);
    }
    public static void Main(string[] args)
    {
        LINQ li=new LINQ();
        li.read();
        li.display();
    }
}