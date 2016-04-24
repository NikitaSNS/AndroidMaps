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
    [Activity(Label = "FriendListActivity")]
    public class FriendListActivity : Activity
    {
        public List<string> friendsList;
        public ListView frView;
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            SetContentView(Resource.Layout.Main);
            frView = FindViewById<ListView>(Resource.Id.listView1);
            friendsList = new List<string>();
            friendsList.Add("Petya");

            ArrayAdapter<string> adapter = new ArrayAdapter<string>(this, Android.Resource.Layout.SimpleListItemActivated1, friendsList);

            frView.Adapter = adapter;
            frView.ChoiceMode = ChoiceMode.Multiple;
        }
    }
}