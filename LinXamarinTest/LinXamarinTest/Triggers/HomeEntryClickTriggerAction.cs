using System;
using Xamarin.Forms;

namespace LinXamarinTest.Triggers
{
	public class HomeEntryClickTriggerAction : TriggerAction<Entry>
	{
		protected override void Invoke(Entry sender)
		{
			double rs;

			bool isValid = double.TryParse(sender.Text, out rs);

			sender.TextColor = isValid ? Color.Gray : Color.Red;
		}
	}
}
