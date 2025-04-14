//
//  DotnetNewBinding.swift
//  NewBinding
//
//  Created by .NET MAUI team on 6/18/24.
//

import Foundation
import OneSignalFramework

@objc(DotnetNewBinding)
public class DotnetNewBinding : NSObject
{

    @objc
    public static func getString(myString: String) -> String {
        return myString  + " from swift!"
    }

    public static func setLogLevel(logLeve: ONE_S_LOG_LEVEL) -> Void {
        OneSignal.Debug.setLogLevel(logLeve)
    }
    
    public static func oneSignalInit(appId: String, launchOptions: [UIApplication.LaunchOptionsKey : Any]? = nil)
    {
        OneSignal.initialize(appId, withLaunchOptions: launchOptions)
    }
    
    public static func notificationsRequestPermission(_ block: @escaping OSUserResponseBlock) {
        OneSignal.Notifications.requestPermission(block);
    }
}
