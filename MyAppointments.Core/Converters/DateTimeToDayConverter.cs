using System;
using MvvmCross.Platform.Converters;

namespace MyAppointments.Core.Converters
{
	public class DateTimeToDayConverter : MvxValueConverter<DateTime, string>
	{
		protected override string Convert(DateTime value, Type targetType, object parameter,
			System.Globalization.CultureInfo culture)
		{
			return value.ToString("MMM dd, yyyy");
		}
	}
}