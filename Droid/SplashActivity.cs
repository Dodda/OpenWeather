﻿
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using OpenWeather.ViewModels;

namespace OpenWeather.Droid
{
    [Activity(MainLauncher = true, Icon = "@mipmap/icon")]
    public class SplashActivity : Activity
    {
        public SplashViewModel ViewModel { get; set; }

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            ViewModel = new SplashViewModel();
            SetContentView(Resource.Layout.SplashLayout);
            TextView textView = FindViewById<TextView>(Resource.Id.splashText);
            textView.Text = ViewModel.SplashMessage;
        }

        protected override void OnStart()
        {
            base.OnStart();
            Task.Run(() =>
            {
                Thread.Sleep(ViewModel.WaitTime);
                RunOnUiThread(() => StartActivity(typeof(HomeActivity)));
            });
        }
    }
}
