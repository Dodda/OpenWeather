// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace OpenWeather.iOS
{
    [Register ("CityViewController")]
    partial class CityViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton buttonFavorites { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel textCityName { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel textHumidity { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel textLatitude { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel textLongitude { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel textPressure { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel textTemperature { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel textWindSpeed { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (buttonFavorites != null) {
                buttonFavorites.Dispose ();
                buttonFavorites = null;
            }

            if (textCityName != null) {
                textCityName.Dispose ();
                textCityName = null;
            }

            if (textHumidity != null) {
                textHumidity.Dispose ();
                textHumidity = null;
            }

            if (textLatitude != null) {
                textLatitude.Dispose ();
                textLatitude = null;
            }

            if (textLongitude != null) {
                textLongitude.Dispose ();
                textLongitude = null;
            }

            if (textPressure != null) {
                textPressure.Dispose ();
                textPressure = null;
            }

            if (textTemperature != null) {
                textTemperature.Dispose ();
                textTemperature = null;
            }

            if (textWindSpeed != null) {
                textWindSpeed.Dispose ();
                textWindSpeed = null;
            }
        }
    }
}