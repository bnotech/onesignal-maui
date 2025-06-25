using Foundation;
using UIKit;

namespace NewBindingMaciOS
{
	// @interface DotnetNewBinding : NSObject
	[BaseType (typeof(NSObject))]
	// @interface DotnetNewBinding
	interface DotnetNewBinding
	{
		// +(void)setLogLevelWithLogLeve:(id)logLeve;
		[Static]
		[Export ("setLogLevelWithLogLeve:")]
		void SetLogLevelWithLogLeve (OneSignalLogLevel logLevel);

		// +(void)oneSignalInitWithAppId:(NSString * _Nonnull)appId launchOptions:(id)launchOptions;
		[Static]
		[Export ("oneSignalInitWithAppId:launchOptions:")]
		void OneSignalInitWithAppId (string appId, NSObject launchOptions);

		// +(void)notificationsRequestPermission:(id)block;
		[Static]
		[Export ("notificationsRequestPermission:")]
		void NotificationsRequestPermission (NSObject block);
	}
}
