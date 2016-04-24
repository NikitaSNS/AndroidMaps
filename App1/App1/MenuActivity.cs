using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace App1
{
    [Activity(Label = "MenuActivity")]
    public class MenuActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            this.Window.AddFlags(WindowManagerFlags.Fullscreen);
            RequestWindowFeature(WindowFeatures.NoTitle);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Menu);

            ImageView button1 = FindViewById<ImageView>(Resource.Id.imageView2);
            ImageView button2 = FindViewById<ImageView>(Resource.Id.imageView3);
            ImageView button3 = FindViewById<ImageView>(Resource.Id.imageView4);

            button1.Click += delegate { StartActivity(typeof (FriendListActivity)); };
            button2.Click += delegate { StartActivity(typeof(FriendListActivity)); };
            button3.Click += delegate { StartActivity(typeof(FriendListActivity)); };
        }
    }
}