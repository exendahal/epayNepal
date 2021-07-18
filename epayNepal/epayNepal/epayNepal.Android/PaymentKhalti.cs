
using Android.Content;
using Com.Khalti.Checkout.Helper;
using Com.Khalti.Utils;
using epayNepal.Droid;
using Java.Lang;
using Xamarin.Forms;

[assembly: Xamarin.Forms.Dependency(typeof(PaymentKhalti))]
namespace epayNepal.Droid
{
    public class PaymentKhalti : MakePaymentKhalti
    {
        Context currentContext = (MainActivity)Forms.Context;
        // private Config config;
        // Require Parameters
        System.String publicKey = Constant.Pub;
        Long amount = (Long)100L; // In Paisa    
        private Config config;

        public void getDataKhalti(string amt, string productName, string uniqueId)
        {
            Long val = Long.ValueOf(amt);
            Long amount = val;
            config = new Config.Builder(publicKey, uniqueId, productName, amount, new myKhalticlass()).Build();
            KhaltiCheckOut khaltiCheckOut2 = new KhaltiCheckOut(currentContext, config);
            khaltiCheckOut2.Show();
        }


    }
}