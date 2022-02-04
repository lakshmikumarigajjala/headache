using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace collections
{
    class OrderProcessing
    {
        ArrayList ListofParts;

        //public bool PartID { get;  set; }

        public OrderProcessing()
        {
            ListofParts = new ArrayList();
        }
        public void CreateInventory()
        {
            //Part One;

            // Create a Part object using its properties
          Part  One = new Part();
            One.PartNumber = "GD646";
            One.PartName = "Bearing Clutch Pilot  ";
            One.UnitPrice = 9.75M;
            One.Quantity = 4;
            // Add the new part to the list
            ListofParts.Add(One);

            // Create a Part object using a constructor
            One = new Part("EU473", "Belt Accessory Drive  ", 10, 6.75M);
            // Add the new part to the list
            ListofParts.Add(One);

            // Do the same to complete the list
            One = new Part("AH325", "Break Drum            ", 5, 20.55M);
            ListofParts.Add(One);
            One = new Part("KS745", "Right Mirror          ", 2, 9.35M);
            ListofParts.Add(One);
            One = new Part("KE374", "Break Shoe            ", 6, 20.25M);
            ListofParts.Add(One);
            One = new Part("GD943", "Signal Lamp Assembly  ", 4, 74.55M);
            ListofParts.Add(One);
            One = new Part("GH386", "Bearing Input Shaft   ", 3, 45.25M);
            ListofParts.Add(One);
            One = new Part("WD394", "Brake Disc            ", 14, 85.50M);
            ListofParts.Add(One);
            One = new Part("TR944", "Front Wheel Lug Nut   ", 7, 10.75M);
            ListofParts.Add(One);
            One = new Part("GD844", "Front Pump Gasket     ", 6, 10.72M);
            ListofParts.Add(One);
            One = new Part("GD933", "Filter Steering       ", 4, 12.55M);
            ListofParts.Add(One);
            One = new Part("GW478", "Air Control Valve     ", 8, 35.25M);
            ListofParts.Add(One);
            One = new Part("LA943", "Clutch Master Clndr   ", 5, 124.55M);
            ListofParts.Add(One);
            One = new Part("RU688", "Tie Rod               ", 12, 32.55M);
            ListofParts.Add(One);
            One = new Part("PP797", "Ball Joint            ", 14, 25.75M);
            ListofParts.Add(One);
            One = new Part("RA292", "Drive Belt            ", 10, 10.65M);
            ListofParts.Add(One);
            One = new Part("AG778", "Oil Filter            ", 8, 6.25M);
            ListofParts.Add(One);
            One = new Part("KQ820", "Timing Belt           ", 1, 45.95M);
            ListofParts.Add(One);
            One = new Part("GT722", "Intake Manifold Gask  ", 4, 18.55M);
            ListofParts.Add(One);
            One = new Part("WA502", "Spark Plug Seal       ", 24, 4.15M);
            ListofParts.Add(One);
            One = new Part("AL848", "Air Filter            ", 32, 15.65M);

            // Create a Part object using its properties
            One = new Part();
            One.PartNumber = "GD646";
            One.PartName = "Bearing Clutch Pilot  ";
            One.UnitPrice = 9.75M;
            One.Quantity = 4;
            // Add the new part to the list
            ListofParts.Add(One);

            // Create a Part object using a constructor
            One = new Part("EU473", "Belt Accessory Drive  ", 10, 6.75M);
            // Add the new part to the list
            ListofParts.Add(One);

            // Do the same to complete the list
            One = new Part("AH325", "Break Drum            ", 5, 20.55M);
            ListofParts.Add(One);
            One = new Part("KS745", "Right Mirror          ", 2, 9.35M);
            ListofParts.Add(One);
            One = new Part("KE374", "Break Shoe            ", 6, 20.25M);
            ListofParts.Add(One);
            One = new Part("GD943", "Signal Lamp Assembly  ", 4, 74.55M);
            ListofParts.Add(One);
            One = new Part("GH386", "Bearing Input Shaft   ", 3, 45.25M);
            ListofParts.Add(One);
            One = new Part("WD394", "Brake Disc            ", 14, 85.50M);
            ListofParts.Add(One);
            One = new Part("TR944", "Front Wheel Lug Nut   ", 7, 10.75M);
            ListofParts.Add(One);
            One = new Part("GD844", "Front Pump Gasket     ", 6, 10.72M);
            ListofParts.Add(One);
            One = new Part("GD933", "Filter Steering       ", 4, 12.55M);
            ListofParts.Add(One);
            One = new Part("GW478", "Air Control Valve     ", 8, 35.25M);
            ListofParts.Add(One);
            One = new Part("LA943", "Clutch Master Clndr   ", 5, 124.55M);
            ListofParts.Add(One);
            One = new Part("RU688", "Tie Rod               ", 12, 32.55M);
            ListofParts.Add(One);
            One = new Part("PP797", "Ball Joint            ", 14, 25.75M);
            ListofParts.Add(One);
            One = new Part("RA292", "Drive Belt            ", 10, 10.65M);
            ListofParts.Add(One);
            One = new Part("AG778", "Oil Filter            ", 8, 6.25M);
            ListofParts.Add(One);
            One = new Part("KQ820", "Timing Belt           ", 1, 45.95M);
            ListofParts.Add(One);
            One = new Part("GT722", "Intake Manifold Gask  ", 4, 18.55M);
            ListofParts.Add(One);
            One = new Part("WA502", "Spark Plug Seal       ", 24, 4.15M);
            ListofParts.Add(One);
            One = new Part("AL848", "Air Filter            ", 32, 15.65M);


        }
        public void AddNewItem()
        {
            string ID;
            string Name;
            decimal Price;
            int qty;
            Console.Write("enter Item Number(example:PD764):");
            ID = Console.ReadLine();
            Console.WriteLine("enter the nmae or a short description:");
            Name = Console.ReadLine();
            Console.Write("Enter Unit Price:");
            Price = decimal.Parse(Console.ReadLine());
            Console.Write("how many?");
            qty = int.Parse(Console.ReadLine());
            Part NewPart = new Part(ID, Name, qty, Price);
            ListofParts.Add(NewPart);


        }
        public void showInventory()
        {
            Console.WriteLine("\n.........................................................");
            Console.WriteLine("==College Park Auto Parts==Store Inventory");
            Console.WriteLine("\n.............................................................");
            Console.WriteLine("Item Description Price Qty");
            foreach (Part item in ListofParts)
            {
                Console.WriteLine(item.PartName);
                Console.WriteLine(item.partNumber);
                Console.WriteLine(item.Quantity);
                Console.WriteLine(item.UnitPrice);
            }

            //    for (int i = 0; i < ListofParts.Count; i++)
            //    {
            //        Part One = (Part)ListofParts[i];
            //        Console.WriteLine("{0}{1}{2,6}{3,5}",
            //        One.partNumber, One.PartName,One.UnitPrice,One.Quantity);

            //    }
            //    Console.WriteLine("...........................................\n");
            //}
        }
        public void ProcessOrder()
        {
            ArrayList Choices = new ArrayList();
            Part AnItem;
            string PartId;
            int Qty;
            do
            {
                Console.Write("enter the part number (q to stops):");
                PartId = Console.ReadLine();
                for (int i = 0; i < ListofParts.Count; i++)
                {
                    AnItem = new Part();
                    if (PartId == ((Part)ListofParts[i]).PartName)
                    {
                        AnItem.partNumber = ((Part)ListofParts[i]).partNumber;
                        AnItem.PartName = ((Part)ListofParts[i]).PartName;
                        AnItem.UnitPrice = ((Part)ListofParts[i]).UnitPrice;
                        try
                        {
                            Console.Write("how many?");
                            Qty = int.Parse(Console.ReadLine());
                            AnItem.Quantity = Qty;
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("invalid quantity");
                        }
                        Choices.Add(AnItem);
                        break;
                    }
                }
            }
            while (PartId != "q" && PartId != "Q");

            DisplayReceipt(Choices);
        }

    
    public void DisplayReceipt(ArrayList choices)
        {
            decimal SubTotal = 0.0M, TotalOrder = 0.00M;
            Console.WriteLine(".............................................");
            Console.WriteLine("==College park auto parts==Receipt");
            Console.WriteLine("..............................................");
            Console.WriteLine("Part # qty Description price Subtotal");
            Console.WriteLine("....................................");

            for (int i = 0; i < ListofParts .Count; i++)
            {
                Part One = (Part)ListofParts[i];

                SubTotal = One.UnitPrice * One.Quantity;
                TotalOrder += SubTotal;

                //Console.WriteLine("{0}   {1}   {2}    {3,6}    {4,6}",
                //                  One.PartNumber, One.Quantity, One.PartName,
                //                  One.UnitPrice, SubTotal);ssi

            }

            Console.WriteLine("------+---+-------------------------+-------+-----------");
            Console.WriteLine("Total Order: {0:C}", TotalOrder);
            Console.WriteLine("========================================================\n");

        }
    }
}
