using System;
using Android.Content;
using Com.Swifttechnology.Imepaysdk;
using epayNepal.Droid;

[assembly: Xamarin.Forms.Dependency(typeof(paymentImePay))]
namespace epayNepal.Droid
{
    public class paymentImePay : MainActivity, MakePaymentImepay
    {
        Context currentContext = Android.App.Application.Context;
        String merchantCode = "TEST";
        String merchantName = "TEST";
        String module = "TEST";
        String username = "TEST";
        String password = "TEST";
        String reference_value = "Reference Value";
        String amount = "2000.00";
        String merchant_transaction_recording_url = "https://merchantname.com/merchant_transaction_recording_method";


        public void getDataImePay(string amt, string productName, string uniqueId)
        {

            IMEPayment imePayment = new IMEPayment(currentContext, ENVIRONMENT.Test);
            imePayment.PerformPayment(merchantCode, merchantName, merchant_transaction_recording_url, amount, reference_value, module, username, password, new myImeClass());

        }


    }
}