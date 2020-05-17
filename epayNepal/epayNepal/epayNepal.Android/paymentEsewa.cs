using Android.App;
using Android.Content;
using Com.Esewa.Android.Sdk.Payment;
using epayNepal.Droid;
using System;
using System.Diagnostics;
using Xamarin.Forms;

[assembly: Xamarin.Forms.Dependency(typeof(paymentEsewa))]
namespace epayNepal.Droid
{
    public class paymentEsewa : MainActivity, MakePaymentesewa
    {
        Context currentContext = Android.App.Application.Context;
        System.String CONFIG_ENVIRONMENT = "test";
        int REQUEST_CODE_PAYMENT = 1;
        private ESewaConfiguration eSewaConfiguration;
        System.String MERCHANT_ID = "JB0BBQ4aD0UqIThFJwAKBgAXEUkEGQUBBAwdOgABHD4DChwUAB0R";
        System.String MERCHANT_SECRET_KEY = "BhwIWQQADhIYSxILExMcAgFXFhcOBwAKBgAXEQ==";

        public void getDataEsewa(string amt, string productName, string uniqueId)
        {

            //Perform Payment here           
            eSewaConfiguration = new ESewaConfiguration().ClientId(MERCHANT_ID).SecretKey(MERCHANT_SECRET_KEY).InvokeEnvironment(CONFIG_ENVIRONMENT);
            ESewaPayment eSewaPayment = new ESewaPayment(amt, productName, uniqueId + nanoTime(), "https://somecallbackurl.com");
            Intent intent = new Intent(Android.App.Application.Context, typeof(ESewaPaymentActivity));
            intent.PutExtra(ESewaConfiguration.EsewaConfiguration, eSewaConfiguration);
            intent.PutExtra(ESewaPayment.EsewaPayment, eSewaPayment);
            ((Activity)Forms.Context).StartActivityForResult(intent, REQUEST_CODE_PAYMENT);
        }

        private static long nanoTime()
        {
            long nano = 10000L * Stopwatch.GetTimestamp();
            nano /= TimeSpan.TicksPerMillisecond;
            nano *= 100L;
            return nano;
        }
    }
}