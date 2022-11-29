using System;
using System.Collections;
using System.Collections.Generic;

    class Queue
    {
   public static void seat(Table seat)
    {
        Table FindSeat = new Table();
    }
    public static void Seat()
    {
        Table seat = new Table();
        return;
    }
    static void RegisterQueue()
    {
        Console.Clear();
        int AddToQueue = 0;
        Console.WriteLine("What seat do you prefer?");
        Console.WriteLine("1. Small Table 1-2 people");
        Console.WriteLine("2. Medium Table 3-4 people");
        Console.WriteLine("3. Large Table 5+ people");
        AddToQueue = int.Parse(Console.ReadLine());
        switch (AddToQueue)
        {
            case 1: Console.WriteLine("Small Table Selected");
            break;
            case 2: Console.WriteLine("Medium Table Selected");
            break;
            case 3: Console.WriteLine("Large Table Selected");
            break;
            default: Console.WriteLine("Wrong Input!!!");

            break;
        }
    }
}
