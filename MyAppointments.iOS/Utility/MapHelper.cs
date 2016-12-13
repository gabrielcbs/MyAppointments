using System;
using CoreLocation;
using MapKit;
using MyAppointments.Core.Models;

namespace MyAppointments.iOS
{
	public class MapHelper
	{
		/// <summary>
		/// Converts miles to latitude degrees
		/// </summary>
		public double MilesToLatitudeDegrees(double miles)
		{
			double earthRadius = 3960.0;
			double radiansToDegrees = 180.0 / Math.PI;
			return (miles / earthRadius) * radiansToDegrees;
		}

		/// <summary>
		/// Converts miles to longitudinal degrees at a specified latitude
		/// </summary>
		public double MilesToLongitudeDegrees(double miles, double atLatitude)
		{
			double earthRadius = 3960.0;
			double degreesToRadians = Math.PI / 180.0;
			double radiansToDegrees = 180.0 / Math.PI;

			// derive the earth's radius at that point in latitud
			double radiusAtLatitude = earthRadius * Math.Cos(atLatitude * degreesToRadians);
			return (miles / radiusAtLatitude) * radiansToDegrees;
		}

		public MKCoordinateRegion GetCoordinateRegion(CityCoordinates cityCoordinates)
		{
			var coords = new CLLocationCoordinate2D(cityCoordinates.Latitude, cityCoordinates.Longitude);

			var span = new MKCoordinateSpan
				(MilesToLatitudeDegrees(20), MilesToLongitudeDegrees(20, cityCoordinates.Latitude));
			
			return new MKCoordinateRegion(coords, span);
		}
	}
}
