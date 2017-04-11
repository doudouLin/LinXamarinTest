using System;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

using Android.Gms.Common;
using Firebase.Messaging;
using Firebase.Iid;
using Android.Util;

namespace LinXamarinTest.Droid
{
	[Activity (Label = "Lin", Icon = "@drawable/icon", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
	public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsApplicationActivity
	{
        TextView msgText;
        const string TAG = "MainActivity";

		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

            //Log.Debug(TAG, "google app id: " + Resource.String.google_app_id);

            //if (Intent.Extras != null)
            //{
            //    foreach (var key in Intent.Extras.KeySet())
            //    {
            //        var value = Intent.Extras.GetString(key);
            //        Log.Debug(TAG, "Key: {0} Value: {1}", key, value);
            //    }
            //}


            //SetContentView(Resource.Layout.Main);

            //msgText = FindViewById<TextView>(Resource.Id.msgText);

            //var logTokenButton = FindViewById<Button>(Resource.Id.logTokenButton);
            //logTokenButton.Click += delegate {
            //    Log.Debug(TAG, "InstanceID token: " + FirebaseInstanceId.Instance.Token);
            //};

            //IsPlayServicesAvailable();

            global::Xamarin.Forms.Forms.Init (this, bundle);

            LoadApplication (new LinXamarinTest.App ());
        }

        public bool IsPlayServicesAvailable()
        {
            int resultCode = GoogleApiAvailability.Instance.IsGooglePlayServicesAvailable(this);
            if (resultCode != ConnectionResult.Success)
            {
                if (GoogleApiAvailability.Instance.IsUserResolvableError(resultCode))
                    msgText.Text = GoogleApiAvailability.Instance.GetErrorString(resultCode);
                else
                {
                    msgText.Text = "Sorry, this device is not supported";
                    Finish();
                }
                return false;
            }
            else
            {
                msgText.Text = "Google Play Services is available.";
                return true;
            }
        }
    }
}

