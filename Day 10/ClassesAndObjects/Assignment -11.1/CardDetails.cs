using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardFunction
{
    internal class CardDetails
    {
        public string CardHolderName;
        public int CardNumber;
        public int ExpiryMonth;
        public int ExpiryYear;
        public int CVC;

        public List<CardDetails> Card = new List<CardDetails>();

        public void AddDetails(int num)
        {
            //int[] Array = new int[num];

            for (int i = 0; i < num; i++)
            {
                CardDetails details = new CardDetails();
                Console.Write("Enter the card holder name : ");
                details.CardHolderName = Console.ReadLine();

                Console.Write("Enter card number : ");
                details.CardNumber = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter expiry month");
                details.ExpiryMonth = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter expiry year");
                details.ExpiryYear = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter CVC");
                details.CVC = int.Parse(Console.ReadLine());

                Card.Add(details);
            }
        }

        public void SearchCard()
        {
            Console.Write("Enter the card number to be searched : ");
            int searchCard = int.Parse(Console.ReadLine());

            foreach (var data in Card)
            {
                if(data.CardNumber == searchCard)
                {
                    Console.WriteLine("Card found");
                }
                else
                {
                    break;
                }
            }
        }

        public void Update()
        {
            CardDetails details = new CardDetails();
            Console.WriteLine("Enter the ID number to update the details");
            int ID = int.Parse(Console.ReadLine());
            foreach (var data in Card)
            {
                if (data.CardNumber == ID)
                {
                    Console.Write("Enter the new card number :");
                    details.CardNumber = int.Parse(Console.ReadLine());
                    Console.Write("Enter the expiry month :");
                    details.ExpiryMonth = int.Parse(Console.ReadLine());
                    Console.Write("Enter the expiry year :");
                    details.ExpiryYear = int.Parse(Console.ReadLine());
                    Console.Write("Enter the CVC :");
                    details.CVC = int.Parse(Console.ReadLine());

                    Card.Add(details);

                    Console.WriteLine("After updating : ");
                    Console.WriteLine($"Name of account holder : {data.CardHolderName}");
                    Console.WriteLine($"Card number : {data.CardNumber}");
                    Console.WriteLine($"Expiry date : {data.ExpiryMonth}");
                    Console.WriteLine($"Expiry year : {data.ExpiryYear}");
                    Console.WriteLine($"CVC : {data.CVC}");
                }
                else
                {
                    Console.WriteLine("Card Number not found"); ;
                }
            }
        }

        //public void DeleteCard()
        //{
        //    CardDetails details = new CardDetails();
        //    Console.WriteLine("Enter the card number where the data has to be deleted");
        //    int cardNum = int.Parse(Console.ReadLine());
        //    foreach (var data in Card)
        //    {
        //        if (data.CardNumber == cardNum)
        //        {
                   
        //        }
        //    }
        //}
    }
}
