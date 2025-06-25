namespace MauiSample;

#if IOS
using NewBinding = NewBindingMaciOS.DotnetNewBinding;
#elif ANDROID
using NewBinding = NewBindingAndroid.DotnetNewBinding;
#elif (NETSTANDARD || !PLATFORM) || (NET6_0_OR_GREATER && !IOS && !ANDROID)
using NewBinding = System.Object;
#endif

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();

		#if IOS
		NewBinding.SetLogLevelWithLogLeve(NewBindingMaciOS.OneSignalLogLevel.Info);
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

