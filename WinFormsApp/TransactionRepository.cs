using System;
using System.Collections.Generic;
using System.Linq;

namespace WinFormsApp
{
    public class TransactionRepository
    {
        private readonly List<Transaction> _transactions;

        public TransactionRepository()
        {
            _transactions = GenerateFakeTransactions(200);
        }

        public IEnumerable<Transaction> GetTransactions()
        {
            return _transactions;
        }

        private List<Transaction> GenerateFakeTransactions(int count)
        {
            var rnd = new Random(123);
            var descriptions = new[]
            {
                "Coffee",
                "Groceries",
                "Salary",
                "Rent",
                "Utilities",
                "Subscription",
                "Gym",
                "Taxi",
                "Book",
                "Dining"
            };

            var list = new List<Transaction>(count);
            var start = DateTime.Today.AddDays(-365);
            for (var i = 0; i < count; i++)
            {
                var desc = descriptions[rnd.Next(descriptions.Length)];
                var amount = Math.Round((decimal)(rnd.NextDouble() * 2000 - 1000), 2);
                var date = start.AddDays(rnd.Next(365)).AddMinutes(rnd.Next(0, 1440));
                list.Add(new Transaction
                {
                    Id = Guid.NewGuid(),
                    Date = date,
                    Description = desc,
                    Amount = amount
                });
            }

            // add some predictable entries for testing
            list.Add(new Transaction { Id = Guid.NewGuid(), Date = DateTime.Today, Description = "Coffee at Central", Amount = -3.5m });
            list.Add(new Transaction { Id = Guid.NewGuid(), Date = DateTime.Today, Description = "Grocery Store", Amount = -76.23m });
            list.Add(new Transaction { Id = Guid.NewGuid(), Date = DateTime.Today.AddDays(-1), Description = "Salary September", Amount = 2500m });

            return list.OrderByDescending(t => t.Date).ToList();
        }
    }
}
