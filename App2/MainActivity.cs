using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;


namespace KonturMaps
{
    [Activity(Label = "App2", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        int userId = 1, tryId = 0;

        string tempP = string.Empty;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            var intent = new Intent(this, typeof(FriendActivity));
            if (userId == tryId)
            {
                StartActivity(intent);
            }
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            // Get our button from the layout resource,
            // and attach an event to it
            Button button = FindViewById<Button>(Resource.Id.acceptButton);
            
            EditText password = FindViewById<EditText>(Resource.Id.editText1);
            EditText telNum = FindViewById<EditText>(Resource.Id.editText2);

            button.Click += (object sender, EventArgs e) =>
            {
                if (String.IsNullOrWhiteSpace(password.Text) || String.IsNullOrWhiteSpace(telNum.Text))
                {
                    var callDialog = new AlertDialog.Builder(this);
                    callDialog.SetMessage("Введите данные!");
                    callDialog.SetNegativeButton("Cancel", delegate { });
                    callDialog.Show();
                }
                else
                {
                    tempP = password.Text + telNum.Text;
                    StartActivity(intent);
                }

            };
        }
    }
}

