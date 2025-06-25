//
//  DotnetNewBinding.swift
//  NewBinding
//
//  Created by .NET MAUI team on 6/18/24.
//

import Foundation
import OneSignalFramework

@objc(OneSignalSDKBinding)
public class OneSignalSDKBinding : NSObject
{
    @objc
    public static func setLogLevel(logLeve: ONE_S_LOG_LEVEL) -> Void {
        OneSignal.Debug.setLogLevel(logLeve)
    }
    
    @objc
    public static func oneSignalInit(appId: String, launchOptions: [UIApplication.LaunchOptionsKey : Any]? = nil)
    {
        OneSignal.initialize(appId, withLaunchOptions: launchOptions)
    }
    
    @objc
    public static func notificationsRequestPermission(_ block: @escaping OSUserResponseBlock) {
        OneSignal.Notifications.requestPermission(block);
    }
}
