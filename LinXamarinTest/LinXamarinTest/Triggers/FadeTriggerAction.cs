using System;
using Xamarin.Forms;

namespace LinXamarinTest.Triggers
{
	public class FadeTriggerAction : TriggerAction<VisualElement>
	{
		public FadeTriggerAction() { }

		public int StartsFrom
		{
			get;
			set;
		}

		protected override void Invoke(VisualElement visual)
		{
			visual.Animate("0", 
			               new Animation((d) => { 
								var val = StartsFrom == 1 ? d : 1 - d;
								visual.BackgroundColor = Color.FromRgb(1, val, 1);
						   }), 
			               length: 1000, 
			               easing: Easing.Linear);
		}
	}
}
