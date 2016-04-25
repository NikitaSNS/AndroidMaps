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

namespace App1.Resources.layout
{
    [Activity(Label = "newmapActivity")]
    public class newmapActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            this.Window.AddFlags(WindowManagerFlags.Fullscreen);
            RequestWindowFeature(WindowFeatures.NoTitle);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.newmaplayout);
            // Create your application here
        }
    }
}