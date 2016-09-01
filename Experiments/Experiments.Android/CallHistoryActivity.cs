using Android.App;
using Android.OS;
using Android.Widget;
using AndroidResource = Android.Resource;

namespace Experiments.Android
{
	/// <summary>
	/// Hello, Android Multiscreen
	/// https://developer.xamarin.com/guides/android/getting_started/hello,android_multiscreen/hello,android_multiscreen_quickstart/
	/// </summary>
	[Activity(Label = "@string/callHistory")]
	public class CallHistoryActivity : ListActivity
	{
		protected override void OnCreate(Bundle savedInstanceState)
		{
			base.OnCreate(savedInstanceState);

			// Create your application here

			var phoneNumbers = Intent.Extras.GetStringArrayList("phone_numbers") ?? new string[0];
			this.ListAdapter = new ArrayAdapter<string>(this, AndroidResource.Layout.SimpleListItem1, phoneNumbers);
		}
	}
}
