using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignmentonecsharp
{

    class Product
    {

        private const double FoodVaVATRate = 0.12, otherVATRate = 0.25;
        private string name;
        private double unitprice;
        private int count;
        private bool foodItem;
        private double totalNetValue;
        public void start()
        {
            //Read input
            ReadInput();
            //calculate total tax
            CalcutlateValues(count, unitprice, foodItem);
            //Calculate totalNetPrice,total price
            PrintReceipt(name, unitprice, totalNetValue);
        }



        public void ReadInput()
        {


            //1.Read name of the product
            ReadName();
            //2.Read price without VAT
            ReadNetUnitPrice();
            //3.Ask the user if the item is a food item
            ReadIfFoodItem();
            //4.Read number of items (quantity)
            ReadCount();

        }

        private void ReadName()
        {
            //  String name;
            Console.Write(" Enter the product name :");
            name = Console.ReadLine().ToString();
        }
        private void ReadNetUnitPrice()
        {


            String _unitprice;
            Console.Write("unit price:");
            _unitprice = Console.ReadLine();
            //bool Valid = false;
            //int Number;
            //while (Valid == false)
            //{
            //    string Input = Console.ReadLine();
            //    if (int.TryParse(_unitprice, out Number))
            //    {
            //        Valid = true;
            //    }
            //    else
            //    {
            //        Console.WriteLine("Not an integer, please try again.");
            //        ReadNetUnitPrice();
            //    }
            //}
            unitprice = double.Parse(_unitprice, System.Globalization.NumberStyles.AllowDecimalPoint, System.Globalization.NumberFormatInfo.InvariantInfo);
         
        }
        private void ReadCount()
        {
            String _count;
            Console.Write("count:");
            _count = Console.ReadLine();

            int _icount;



            if (int.TryParse(_count, out _icount))
            {
                count = _icount;

            }
            else
            {
                ReadCount();


            }


        }


        private void ReadIfFoodItem()
        {
            // bool foodItem;
            //3.Ask the user if the item is a food item
            Console.Write("Food item? (y or n ):");
            char res;
            bool response = char.TryParse(Console.ReadLine(), out res);
            if (response == true)
            {
                foodItem = (res == 'Y' || res == 'y') ? true : false;
                if ((res == 'Y' || res == 'y'))
                {
                    foodItem = true;
                    // Console.WriteLine("this is  a food product!!!");
                }

                else if ((res == 'N' || res == 'n'))
                {
                    foodItem = false;
                    //Console.WriteLine("this is not a food product!!!");
                }


                else
                {

                    Console.WriteLine("enter the right character");
                    ReadIfFoodItem();
                }
            }


        }


        //calculate totalNet
        private void CalcutlateValues(int count, double unitprice, bool foodItem)
        {

            // double totalNetValue;
            if (foodItem == true)
                totalNetValue = (FoodVaVATRate * unitprice * count) + (unitprice * count);
            else
                totalNetValue = (otherVATRate * unitprice * count) + (unitprice * count);

        }

        private void PrintReceipt(string name, double unitprice, double totalNetValue)
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();


            Console.WriteLine("*************** WELCOME TO APU's SUPERMARKET *******\n");

            //priting the name of the item 
            Console.Write("**");
            Console.Write($"****Name of the product ");
            Console.CursorLeft = Console.BufferWidth - 40;
            Console.WriteLine(name);



            //printing the count of the item 
            Console.Write($"****Quantity ");
            Console.CursorLeft = Console.BufferWidth - 40;
            Console.WriteLine(count);


            //printing the unit price of the item
            Console.Write("****Unit price");
            Console.CursorLeft = Console.BufferWidth - 40;
            Console.WriteLine(unitprice.ToString());

            //checking if the item is food or not 
            if (foodItem == true)
            {
                Console.Write($"****Food item");
                Console.CursorLeft = Console.BufferWidth - 40;
                Console.WriteLine("True");
            }
            else
            {
                Console.Write($"****Food item");
                Console.CursorLeft = Console.BufferWidth - 40;
                Console.WriteLine("False");
            }

            // printing the total pay 
            Console.WriteLine("**");
            Console.Write("**** Total amount to pay :");
            Console.CursorLeft = Console.BufferWidth - 40;
            Console.WriteLine(totalNetValue.ToString());



            // printing the vat value 
            if (foodItem == true)
            {
                Console.Write("**** including VAT at 12% ");
                // Double _foodvatrate;
                // _foodvatrate= FoodVaVATRate * unitprice;
                Console.CursorLeft = Console.BufferWidth - 40;
                Console.WriteLine((FoodVaVATRate * unitprice * count).ToString());
            }
            else
            {
                Console.Write("**** including VAT at 25% ");
                // Double _notfoodvatrate;
                // _notfoodvatrate = otherVATRate * unitprice;
                Console.CursorLeft = Console.BufferWidth - 40;
                Console.WriteLine((otherVATRate * unitprice * count).ToString());
            }
            Console.WriteLine("**");
            Console.WriteLine("**This program has been developed by Abel haile **\n");
            Console.WriteLine("***************PLEASE COME AGAIN ! *************** \n");
            Console.WriteLine();
            Console.WriteLine();

        }


    }

}


     
