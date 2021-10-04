using System;
using System.Collections.Generic;

namespace OpenClosedPrinciple
{

    // O - Open closed principle
    public abstract class Invoice // Sertler yazmamaq ucun hamsina aid olan burda  bir metod ve bezi propertiler yazrig. Diger invoiceleri bu interfaceden toredib implement edirik. 
    {

        public double Amount { get; set; }
        public string Name { get; set; }

        protected Invoice(double amount, string name)
        {
            Amount = amount;
            Name = name;
        }

        public abstract double GetinvoiceDiscount();
    }

    public class FinalInvoice : Invoice
    {
        public FinalInvoice(double amount, string name) : base(amount, name)
        {
        }

        public override double GetinvoiceDiscount() // Invoice interfeysden implement etdiyimiz bu metodun icinde final invoice-e aid kod yazilir.
        {
            return Amount - 40;
        }
    }

    public class ProposedInvoice : Invoice
    {
        public ProposedInvoice(double amount, string name) : base(amount, name)
        {
        }

        public override double GetinvoiceDiscount() // Invoice interfeysden implement etdiyimiz bu metodun icinde proposed invoice-e aid kod yazilir.
        {
            return Amount - 30;
        }
    }

    public class RecurringInvoice : Invoice
    {
        public RecurringInvoice(double amount, string name) : base(amount, name)
        {
        }

        public override double GetinvoiceDiscount() // Invoice interfeysden implement etdiyimiz bu metodun icinde recurrin invoice-ye aid kod yazilir.
        {
            return Amount - 20;
        }
    }

    //Basqa invoice elave etdikde Invoice interfeysinden toredib implement ederek metodda ancaq bu invoice-ye aid kodlar yazilacaq.

    class Program
    {
        static void Main(string[] args)
        {
            //Burda butun invoicelerin melumatlari cap olunur.

            List<Invoice> invoices = new List<Invoice>
            {
                new FinalInvoice(500,"Final invoice"),
                new ProposedInvoice(500,"Propeosed invoice"),
                new RecurringInvoice(500,"Recurring invoice"),
            };

            foreach (var invoice in invoices)
            {
                Console.WriteLine($"{invoice.Name} amount: {invoice.GetinvoiceDiscount()}");
            }
        }
    }
}
