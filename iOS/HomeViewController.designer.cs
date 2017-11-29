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
    [Register ("HomeViewController")]
    partial class HomeViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIActivityIndicatorView ActivityLoader { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton ButtonSearch { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITableView TableFavorites { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField TextSearch { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (ActivityLoader != null) {
                ActivityLoader.Dispose ();
                ActivityLoader = null;
            }

            if (ButtonSearch != null) {
                ButtonSearch.Dispose ();
                ButtonSearch = null;
            }

            if (TableFavorites != null) {
                TableFavorites.Dispose ();
                TableFavorites = null;
            }

            if (TextSearch != null) {
                TextSearch.Dispose ();
                TextSearch = null;
            }
        }
    }
}