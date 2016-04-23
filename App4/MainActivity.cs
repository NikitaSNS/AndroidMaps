using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Android.Provider;
using Android.Telephony;
using Xamarin.Contacts;

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
                var book = new Xamarin.Contacts.AddressBook(this);
                book.RequestPermission().ContinueWith(t => {
                    if (!t.Result)
                    {
                        Console.WriteLine("Permission denied by user or manifest");
                        return;
                    }

                    foreach (Contact contact in book.OrderBy(c => c.LastName))
                    {
                        Console.WriteLine("{0} {1}", contact.FirstName, contact.LastName);
                    }
                }, TaskScheduler.FromCurrentSynchronizationContext());

                var phoneNumbers = new List<List<string>>();
                
                foreach (var item in book)
                {
                    var items = item.Phones.Select(x => x.Number).ToList();
                    phoneNumbers.Add(items);
                }

                var complitedPhoneNumbers = phoneNumbers.Select(x => x[0]).ToList();

                button.Text = string.Format("{0} clicks!", 1);

                #region Get my telephone number
                //TelephonyManager mTelephonyMgr;
                //mTelephonyMgr = (TelephonyManager)GetSystemService(TelephonyService);
                //return mTelephonyMgr.Line1Number;
                #endregion
            };
        }
    }
}

