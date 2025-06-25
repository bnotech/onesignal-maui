package com.onesignal.android.binding;

import android.content.Context;

import com.onesignal.Continue;
import com.onesignal.OneSignal;
import com.onesignal.debug.LogLevel;

import kotlin.coroutines.Continuation;

public class OneSignalSDKBinding {
    public static void SetLogLevel(int level) {
        switch(level) {
            case 0:
                OneSignal.getDebug().setLogLevel(LogLevel.DEBUG);
            case 1:
                OneSignal.getDebug().setLogLevel(LogLevel.ERROR);
            case 2:
                OneSignal.getDebug().setLogLevel(LogLevel.INFO);
            case 3:
                OneSignal.getDebug().setLogLevel(LogLevel.FATAL);
            case 4:
                OneSignal.getDebug().setLogLevel(LogLevel.NONE);
            case 5:
                OneSignal.getDebug().setLogLevel(LogLevel.VERBOSE);
            case 6:
                OneSignal.getDebug().setLogLevel(LogLevel.WARN);
        }
    }

    public static void Initialize(Context context, String appId) {
        OneSignal.initWithContext(context, appId);
    }

    public static void NotificationsRequestPermission(Boolean fallbackToSettings) {
        OneSignal.getNotifications().requestPermission(fallbackToSettings, Continue.none());
    }
}
