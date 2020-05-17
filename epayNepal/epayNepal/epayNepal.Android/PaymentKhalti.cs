
using Android.Content;
using Com.Khalti.CheckOut.Helper;
using Com.Khalti.Utils;
using epayNepal.Droid;
using Java.Lang;
using Xamarin.Forms;

[assembly: Xamarin.Forms.Dependency(typeof(PaymentKhalti))]
namespace epayNepal.Droid
{
    public class PaymentKhalti : MainActivity, MakePaymentKhalti
    {
        Context currentContext = (MainActivity)Forms.Context;
        private Com.Khalti.CheckOut.Api.Config config;
        // Require Parameters
        System.String publicKey = Constant.Pub;
        Long amount = (Long)100L; // In Paisa    

        public void getDataKhalti(string amt, string productName, string uniqueId)
        {
            Long val = Long.ValueOf(amt);
            Long amount = val;
            config = new Com.Khalti.CheckOut.Api.Config(publicKey, uniqueId, productName, "", amount, new myKhalticlass());
            KhaltiCheckOut khaltiCheckOut2 = new KhaltiCheckOut(currentContext, config);
            khaltiCheckOut2.Show();
        }


    }
}