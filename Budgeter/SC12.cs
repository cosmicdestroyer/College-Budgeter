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
    [Activity(Label = "SC12")]
    public class SC12 : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.SC12);

            Button btnScreen11 = FindViewById<Button>(Resource.Id.btnBackSC12);

            btnScreen11.Click += (sender, e) =>
            {
                Intent Screen11 = new Intent(this, typeof(SC11));
                StartActivity(Screen11);

                // Create your application here
            };
        }
    }
}