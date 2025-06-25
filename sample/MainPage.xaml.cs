namespace MauiSample;

#if IOS
using OneSignalSDKBinding = OneSignal.Native.iOS.OneSignalSDKBinding;
#elif ANDROID
using OneSignalSDKBinding = Com.Onesignal.Android.Binding.OneSignalSDKBinding;
#endif

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
		
		#if IOS
		OneSignalSDKBinding.SetLogLevel(OneSignal.Native.iOS.OneSignalLogLevel.Info);
#elif ANDROID
		OneSignalSDKBinding.SetLogLevel(1);
		#endif
		// Call the native binding, which will append a platform specific string to the input string
		var labelText = "Test";

		newBindingSampleLabel.Text = "Hello, " + labelText;
	}

	async void OnDocsButtonClicked(object sender, EventArgs e)
	{
		try
		{
			Uri uri = new Uri("https://learn.microsoft.com/dotnet/communitytoolkit/maui/native-library-interop/get-started");
			await Browser.Default.OpenAsync(uri, BrowserLaunchMode.SystemPreferred);
		}
		catch (Exception ex)
		{
			throw new Exception("Browser failed to launch", ex);
		}
	}
}

