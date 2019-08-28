﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace Budgeter
{
    [Activity(Label = "SC3")]
    public class SC3 : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.SC3);

            Button btnScreen4 = FindViewById<Button>(Resource.Id.btnProceedSC3);

            btnScreen4.Click += (sender, e) =>
            {
                Intent Screen4 = new Intent(this, typeof(SC4));
                StartActivity(Screen4);
            };
        }
    }
}
