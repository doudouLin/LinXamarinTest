using System;
using System.Linq;
using Android.Content;
using Android.Telephony;
using LinXamarinTest.Droid;
using Xamarin.Forms;
using Uri = Android.Net.Uri;

[assembly:Dependency(typeof(PhoneDialer))]
namespace LinXamarinTest.Droid
{
	
	public class PhoneDialer : IDialer
	{

		public bool Dial(string number)
		{
			var context = Forms.Context;
			if (context == null)
				return false;

			var intent = new Intent(Intent.ActionDial);
			intent.SetData(Uri.Parse("tel:" + number));

			if (IsIntentActive(context, intent))
			{
				context.StartActivity(intent);
				return true;
			}

			return false;
		}

		public static bool IsIntentActive(Context context, Intent intent)
		{
			var pm = context.PackageManager;

			var list = pm.QueryIntentServices(intent, 0).Union(pm.QueryIntentServices(intent, 0));

			if (list.Any())
				return true;

			var manager = TelephonyManager.FromContext(context);

			return manager.PhoneType != PhoneType.None;
		}
	}
}
