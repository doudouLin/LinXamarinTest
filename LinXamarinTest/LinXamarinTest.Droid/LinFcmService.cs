using System;
using Android.App;
using Android.Content;
using Android.Util;
using Firebase.Messaging;

namespace LinXamarinTest.Droid
{
	[Service]
	[IntentFilter(new[] { "com.google.firebase.MESSAGING_EVENT" })]
	public class LinFcmService : FirebaseMessagingService
	{
		const string TAG = "LinFcmMsgService";

		public override void OnMessageReceived(RemoteMessage message)
		{
			//base.OnMessageReceived(message);
			//Log.Debug(TAG, "Msg from: " + message.From);
			//Log.Debug(TAG, "Notification body: " + message.GetNotification().Body);
			SendNotification(message.GetNotification().Body);
		}

		void SendNotification(string messageBody)
		{
			var intent = new Intent(this, typeof(MainActivity));
			intent.AddFlags(ActivityFlags.ClearTop);
			var pendingIntent = PendingIntent.GetActivity(this, 0, intent, PendingIntentFlags.OneShot);

			var notificationBuilder = new Notification.Builder(this)
			                                          .SetSmallIcon(Resource.Drawable.fg_notification)
				.SetContentTitle("FCM Message")
				.SetContentText(messageBody)
				.SetAutoCancel(true)
				.SetContentIntent(pendingIntent);

			var notificationManager = NotificationManager.FromContext(this);
			notificationManager.Notify(0, notificationBuilder.Build());
		}
	}
}
