using System;
using System.Collections.Generic;
using System.Linq;

using Foundation;
using UIKit;
using UserNotifications;

namespace LinXamarinTest.iOS
{
	// The UIApplicationDelegate for the application. This class is responsible for launching the 
	// User Interface of the application, as well as listening (and optionally responding) to 
	// application events from iOS.
	[Register("AppDelegate")]
	public partial class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
	{
		#region properties
		protected UIWindow window;
		protected string deviceToken = string.Empty;

		public string DeviceToken
		{
			get{
				return deviceToken;
			}
		}
  		#endregion


		//
		// This method is invoked when the application has loaded and is ready to run. In this 
		// method you should instantiate the window, load the UI into it and then make the window
		// visible.
		//
		// You have 17 seconds to return from this method, or iOS will terminate your application.
		//
		public override bool FinishedLaunching(UIApplication app, NSDictionary options)
		{
			global::Xamarin.Forms.Forms.Init ();
			LoadApplication (new LinXamarinTest.App ());

			//window = new UIWindow(UIScreen.MainScreen.Bounds);
			//window.MakeKeyAndVisible();

			//if (options != null)
			//{
			//	if (options.ContainsKey(UIApplication.LaunchOptionsLocalNotificationKey))
			//	{
			//		UILocalNotification localNotification = options[UIApplication.LaunchOptionsLocalNotificationKey] as UILocalNotification;

			//		if (localNotification != null)
			//		{
			//			new UIAlertView(localNotification.AlertAction, localNotification.AlertBody, null, "OK", null).Show();
			//			UIApplication.SharedApplication.ApplicationIconBadgeNumber = 0;
			//		}
			//	}

			//	if (options.ContainsKey(UIApplication.LaunchOptionsRemoteNotificationKey)
			//	{
			//		NSDictionary remoteNotification = options[UIApplication.LaunchOptionsRemoteNotificationKey] as NSDictionary;

			//		if (remoteNotification != null)
			//		{ 
			//			//new UIAlertView(remoteNotification.AlertAction, remoteNotification.AlertBody, null, "OK", null).Show();
			//			//UIApplication.SharedApplication.ApplicationIconBadgeNumber = 0;
			//		}
			//	}
					
			//}

			//if (UIDevice.CurrentDevice.CheckSystemVersion(8, 0))
			//{
			//	var notificationSettings = UIUserNotificationSettings.GetSettingsForTypes(UIUserNotificationType.Alert | UIUserNotificationType.Badge | UIUserNotificationType.Sound, null);
			//	app.RegisterUserNotificationSettings(notificationSettings);
			//	app.RegisterForRemoteNotifications();
			//}
			//else
			//{
			//	UIRemoteNotificationType notificationTypes = UIRemoteNotificationType.Alert | UIRemoteNotificationType.Badge;
			//	UIApplication.SharedApplication.RegisterForRemoteNotificationTypes(notificationTypes);
			//}

			//UNUserNotificationCenter.Current.RequestAuthorization(UNAuthorizationOptions.Alert, (approved, err) =>
			//{
			//	//handle app

			//});

			return base.FinishedLaunching (app, options);
		}


		//public override void ReceivedLocalNotification(UIApplication application, UILocalNotification notification)
		//{
		//	new UIAlertView(notification.AlertAction, notification.AlertBody, null, "OK", null).Show();
		//	UIApplication.SharedApplication.ApplicationIconBadgeNumber = 0;
		//	//base.ReceivedLocalNotification(application, notification);
		//}

		//public override void ReceivedRemoteNotification(UIApplication application, NSDictionary userInfo)
		//{
		//	//base.ReceivedRemoteNotification(application, userInfo);
		//}

		//public override void RegisteredForRemoteNotifications(UIApplication application, NSData deviceToken)
		//{
		//	deviceToken = deviceToken.ToString();
		//	//base.RegisteredForRemoteNotifications(application, deviceToken);
		//}

		//public override void FailedToRegisterForRemoteNotifications(UIApplication application, NSError error)
		//{
		//	new UIAlertView("Error registering push notifications", error.LocalizedDescription, null, "OK", null).Show();
		//	//base.FailedToRegisterForRemoteNotifications(application, error);
		//}
	}
}
