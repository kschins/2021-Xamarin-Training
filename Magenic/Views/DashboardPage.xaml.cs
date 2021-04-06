using System.Collections.Generic;
using Xamarin.Forms;
using System;

namespace Magenic
{
    public partial class DashboardPage : ContentPage
    {
        public IList<Transaction> Transactions { get; private set; }

        public DashboardPage()
        {
            InitializeComponent();

            Transactions = new List<Transaction>();
            Transactions.Add(new Transaction
            {
                Vendor = "Apple",
                Amount = "$999.89",
                Date = DateTime.Now,
                VendorUrl = "https://www.apple.com"
            });
            Transactions.Add(new Transaction
            {
                Vendor = "Nike",
                Amount = "$115.17",
                Date = DateTime.Now,
                VendorUrl = "https://www.nike.com"
            });
            Transactions.Add(new Transaction
            {
                Vendor = "Whole Foods",
                Amount = "$65.43",
                Date = DateTime.Now,
                VendorUrl = "https://www.wholefoods.com"
            });
            Transactions.Add(new Transaction
            {
                Vendor = "Momofuku",
                Amount = "$155.17",
                Date = DateTime.Now,
                VendorUrl = "https://www.momofuku.com"
            });

            BindingContext = this;
        }

        async void OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Transaction selectedTransaction = e.CurrentSelection[0] as Transaction;
            var transactionDetailPage = new TransactionDetailPage();
            transactionDetailPage.BindingContext = selectedTransaction;
            await Navigation.PushAsync(transactionDetailPage);
        }


    }
}
