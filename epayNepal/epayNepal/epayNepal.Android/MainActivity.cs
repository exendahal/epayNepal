using System;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Android.Content;
using Com.Esewa.Android.Sdk.Payment;

namespace epayNepal.Droid
{
    [Activity(Label = "epayNepal", Icon = "@mipmap/icon", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;

            base.OnCreate(savedInstanceState);

            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            global::Xamarin.Forms.Forms.Init(this, savedInstanceState);
            LoadApplication(new App());
        }
        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }

        protected override void OnActivityResult(int requestCode, [GeneratedEnum] Result resultCode, Intent data)
        {
            base.OnActivityResult(requestCode, resultCode, data);
            string resposeCode = resultCode.ToString();


            if (resposeCode == "Ok")
            {
                String message = data.GetStringExtra(ESewaPayment.ExtraResultMessage);
                Toast.MakeText(Application.Context, "SUCCESSFUL PAYMENT", ToastLength.Long).Show();
                Xamarin.Forms.Application.Current.MainPage.Navigation.PushModalAsync(new Page1());
            }
            else if (resposeCode == "Canceled")
            {
                Toast.MakeText(Application.Context, "Canceled By User", ToastLength.Long).Show();

            }
            else
            {
                Toast.MakeText(Application.Context, "Payment Failed", ToastLength.Long).Show();
            }
        }
    }
}