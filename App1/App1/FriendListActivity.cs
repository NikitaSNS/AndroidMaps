using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Xamarin.Contacts;

namespace App1
{
    [Activity(Label = "FriendListActivity")]
    public class FriendListActivity : Activity
    {
        public List<string> friendsList;
        public ListView frView;
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            this.Window.AddFlags(WindowManagerFlags.Fullscreen);
            RequestWindowFeature(WindowFeatures.NoTitle);

            SetContentView(Resource.Layout.FriendsList);
            frView = FindViewById<ListView>(Resource.Id.listView1);

            friendsList = new List<string>();
            var book = new Xamarin.Contacts.AddressBook(this);
            foreach (var contact in book)
            {
                friendsList.Add(contact.DisplayName);
            }
            

            ArrayAdapter<string> adapter = new ArrayAdapter<string>(this, Android.Resource.Layout.SimpleListItemActivated1, friendsList);

            frView.Adapter = adapter;
            frView.ChoiceMode = ChoiceMode.Multiple;
        }
    }
}