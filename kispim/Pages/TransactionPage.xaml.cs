using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using kispim.Model;
using Microsoft.Maui.Controls;

namespace kispim.Pages;

public partial class TransactionPage : ContentPage
{
    public TransactionPage(Transaction? transaction)
    {
        InitializeComponent();
    }
}