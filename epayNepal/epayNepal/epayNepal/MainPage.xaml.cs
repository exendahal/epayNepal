using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace epayNepal
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        private void Button_Clicked(object sender, EventArgs e)
        {
            DependencyService.Get<MakePaymentesewa>().getDataEsewa("5", "productName", "uniqueId");
        }



        private void Button_Clicked_2(object sender, EventArgs e)
        {
            DependencyService.Get<MakePaymentImepay>().getDataImePay("5", "productName", "uniqueId");
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            DependencyService.Get<MakePaymentKhalti>().getDataKhalti("500", "productName", "uniqueId");
        }
    }
}
