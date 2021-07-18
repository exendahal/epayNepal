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
using Com.Khalti.Checkout.Helper;

namespace epayNepal.Droid
{
    public class myKhalticlass : Java.Lang.Object, IOnCheckOutListener
    {
        public void OnSuccess(IDictionary<string, Java.Lang.Object> p0)
        {
            Toast.MakeText(Application.Context, "SUCCESSFUL PAYMENT", ToastLength.Long).Show();
            //Xamarin.Forms.Application.Current.MainPage.Navigation.PushModalAsync(new Page1());
        }

        public void OnError(string p0, string p1)
        {
            Toast.MakeText(Application.Context, "Payment Failed", ToastLength.Long).Show();
        }

        public void OnError(string p0, IDictionary<string, string> p1)
        {
            Toast.MakeText(Application.Context, "Payment Failed", ToastLength.Long).Show();
        }
    }
}