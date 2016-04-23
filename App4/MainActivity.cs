using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Android.Provider;
using Android.Telephony;

namespace App4
{
    [Activity(Label = "App4", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        int count = 1;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            // Get our button from the layout resource,
            // and attach an event to it
            Button button = FindViewById<Button>(Resource.Id.MyButton);

            //TelephonyManager 

            button.Click += delegate
            {
                TelephonyManager mTelephonyMgr;

                mTelephonyMgr = (TelephonyManager)GetSystemService(TelephonyService);
                string[] projection = 
                {
                    ContactsContract.Contacts.InterfaceConsts.Id,
                    ContactsContract.Contacts.InterfaceConsts.DisplayName
                };
                //return mTelephonyMgr.Line1Number;
                button.Text = string.Format("{0} clicks!", mTelephonyMgr.Line1Number);
            };
        }
    }
}

