namespace Ui.Mobile.Droid
{
	using Android.App;
	using Android.Content.PM;
	using Android.OS;
	using Android.Runtime;
	using System;
	using System.Linq;
	using Xamarin.Forms;
	using Xamarin.Forms.Platform.Android;
	using Platform = Xamarin.Essentials.Platform;

	[Activity(
		Label = "Ui.Mobile",
		Icon = "@mipmap/icon",
		Theme = "@style/MainTheme",
		MainLauncher = true,
		ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation | ConfigChanges.UiMode | ConfigChanges.ScreenLayout | ConfigChanges.SmallestScreenSize)]
	public class MainActivity : FormsAppCompatActivity
	{
		#region methods

		public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Permission[] grantResults)
		{
			Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);
			base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
		}

		protected override void OnCreate(Bundle savedInstanceState)
		{
			base.OnCreate(savedInstanceState);
			Platform.Init(this, savedInstanceState);
			Forms.Init(this, savedInstanceState);
			LoadApplication(new App());
		}

		#endregion
	}
}
