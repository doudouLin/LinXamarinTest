using System;
using System.Globalization;
using LinXamarinTest.Models;
using Xamarin.Forms;

namespace LinXamarinTest.Converters
{
	public class CityCheckConverter : IValueConverter
	{

		public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
		{
			Color IsCapitalLargest = Color.Lime;

			//var largest_city = (Label)parameter;

			if (((string)value).Length > 6)//string.IsNullOrEmpty(largest_city.Text) || largest_city.Text.Equals((string)value))
				IsCapitalLargest = Color.Red;

			return IsCapitalLargest;
		}

		public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
		{
			throw new NotImplementedException();
		}
	}
}
