using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountLinq
{
    class Accounts
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Balance { get; set; }
    }

    class Transaction
    {
        public int TransID { get; set; }
        public int FromAccountID { get; set; }
        public int ToAccountID { get; set; }
        public int Amount { get; set; }
        public DateTime DateTime { get; set; }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            var accounts = new List<Accounts>
            {
                new Accounts
                {
                    ID = 1,
                    Name = "A",
                    Balance = 2000
                },
                new Accounts
                {
                    ID = 2,
                    Name = "B",
                    Balance = 3000
                },
                new Accounts
                {
                    ID = 3,
                    Name = "C",
                    Balance = 4000
                }
            };

            var transaction = new List<Transaction>
            {
                new Transaction
                {
                    TransID = 1,
                    FromAccountID = 1,
                    ToAccountID = 2,
                    Amount = 100
                },
                new Transaction
                {
                    TransID = 2,
                    FromAccountID = 2,
                    ToAccountID = 3,
                    Amount = 200
                }
            };

            var res = transaction
            .Join(
            accounts,
            t => t.FromAccountID    ,
            a => a.ID,
            (transactions, account) => new
            {
                TransactionID = transactions.TransID,
                FromAccountName = account.Name,
                ToAccountID = transactions.ToAccountID,
                Amount = transactions.Amount,
                Date = transactions.DateTime
            })
            .Join(
            accounts,
            transac => transac.ToAccountID,        //join ToAccountID
            a => a.ID,
            (transac, acc) => new
            {
                TransactionID = transac.TransactionID,
                FromAccountName = transac.FromAccountName,
                ToAccountName = acc.Name,
                Amount = transac.Amount,
                Date = transac.Date
            }
            );

            foreach (var item in res)
            {
                Console.WriteLine($"Transaction ID: {item.TransactionID}, From Account: {item.FromAccountName}, To Account: {item.ToAccountName}, Amount: {item.Amount}, Date: {item.Date}");
            }
        }
    }
}
