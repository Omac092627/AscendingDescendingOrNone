
using System;
using System.Collections.Generic;
using System.Text;
using LLLibrary;


public class MainClass
{

    //Driver code for Whiteboard//
    public static void Main()
    {
        LinkedList1 l1 = new LinkedList1();
        l1.Insert(8);
        l1.Insert(8);
        l1.Insert(3);
        l1.Insert(2);
        l1.Insert(1);

        LinkedList1 l2 = new LinkedList1();
        l2.Insert(1);
        l2.Insert(1);
        l2.Insert(1);
        l2.Insert(9);
        l2.Insert(10);


        LinkedList1 l3 = new LinkedList1();
        l3.Insert(12);
        l3.Insert(9);
        l3.Insert(7);
        l3.Insert(10);
        l3.Insert(10);




        Console.WriteLine($"{l1.AscendingDescendingOrNone(l1)}, {l1}");

        Console.WriteLine($"{l2.AscendingDescendingOrNone(l2)}, {l2}");

        Console.WriteLine($"{l3.AscendingDescendingOrNone(l3)}, {l3}");


    }



}









