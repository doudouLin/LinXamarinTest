using Foundation;
using UIKit;

namespace LinXamarinTest.iOS
{
	public class PhoneDialer : IDialer
	{

		public bool Dial(string number)
		{
			return UIApplication.SharedApplication.OpenUrl(new NSUrl("tel:"+number));
		}
	}
}
