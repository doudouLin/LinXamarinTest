using LinXamarinTest.Models;
using LinXamarinTest.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace LinXamarinTest.View
{
	public partial class Detail : ContentPage
	{
        public Detail()
        {
            //var style = new Style(typeof(Button)) {
            //    BasedOn = new Style(typeof(Label)),
         
            //    Setters =
            //    {
            //        new Setter{Property = Button.TextColorProperty, Value="Black"}
            //    }
            //};

            //var rd = new ResourceDictionary();
            //rd.Add(style);
        }

		public Detail (CountryModel cm)
		{
			InitializeComponent ();
            BindingContext = cm;
		}

    }
}
