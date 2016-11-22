using Android.App;
using Android.Widget;
using Android.OS;

namespace Wendy.Droid
{
	[Activity(Label = "Wendy", MainLauncher = true, Icon = "@mipmap/icon")]
	public class MainActivity : Activity
	{
		private EditText _txtAccount;


		protected override void OnCreate(Bundle savedInstanceState)
		{
			base.OnCreate(savedInstanceState);

			// iOS Xcode Custom Class
			// View - Controller Binding (Controller把View載入)
			SetContentView(Resource.Layout.loginflow_loginview);

			// View's Element - Controller's UI Controller Binding
			_txtAccount = FindViewById<EditText>(Resource.Id.loginflow_loginview_textaccount);
		 	var _txtPassword = FindViewById<EditText>(Resource.Id.loginflow_loginview_textpassword);
			var btnlogin = FindViewById<Button>(Resource.Id.loginflow_loginview_btnlogin);
			btnlogin.Click += (sender, e) => { };
		}
	}
}

