using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Com.Swifttechnology.Imepaysdk;

namespace epayNepal.Droid
{
    public class myImeClass : Java.Lang.Object, IMEPaymentCallback
    {
        public void OnSuccess(int p0, string p1, string p2, string p3, string p4, string p5)
        {
            Toast.MakeText(Application.Context, "SUCCESSFUL PAYMENT", ToastLength.Long).Show();
            Xamarin.Forms.Application.Current.MainPage.Navigation.PushModalAsync(new Page1());
        }
    }
}