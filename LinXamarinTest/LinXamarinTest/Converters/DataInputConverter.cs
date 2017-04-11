using System;
using System.Globalization;
using Xamarin.Forms;

namespace LinXamarinTest.Converters
{
	public class DataInputConverter : IValueConverter
	{
		public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
		{
			return (int)value > 2;
		}

		public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
		{
			throw new NotImplementedException();
		}
	}
}
