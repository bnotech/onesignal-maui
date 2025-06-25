using Foundation;
using UIKit;

namespace OneSignal.Native.iOS
{
	// @interface OneSignalSDKBinding : NSObject
	[BaseType(typeof(NSObject))]
	interface OneSignalSDKBinding
	{
		// +(void)setLogLevelWithLogLeve:(id)logLeve;
		[Static]
		[Export("setLogLevelWithLogLeve:")]
		void SetLogLevel(OneSignalLogLevel logLeve);
		
		// +(void)oneSignalInitWithAppId:(NSString * _Nonnull)appId launchOptions:(id)launchOptions;
		[Static]
		[Export("oneSignalInitWithAppId:launchOptions:")]
		void OneSignalInit(string appId, NSObject launchOptions);

		// +(void)notificationsRequestPermission:(id)block;
		[Static]
		[Export("notificationsRequestPermission:")]
		void NotificationsRequestPermission(NSObject block);
	}
}