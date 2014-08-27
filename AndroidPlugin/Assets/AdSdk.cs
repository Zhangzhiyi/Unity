using UnityEngine;
using System.Collections;
using System;

public class AdSdk
{
		public static AndroidJavaObject _plugin;
		public static AndroidJavaObject _activity;

		static AdSdk ()
		{
				if (Application.platform != RuntimePlatform.Android)
						return;
				using (AndroidJavaClass jc = new AndroidJavaClass("com.unity3d.player.UnityPlayer")) {
						_activity = jc.GetStatic<AndroidJavaObject> ("currentActivity"); 
				}
				_activity.Call ("runOnUiThread", new AndroidJavaRunnable (() =>
				{
						using (AndroidJavaClass jc = new AndroidJavaClass("com.iinmobi.adsdk.AdSdk")) {
								_plugin = jc.CallStatic<AndroidJavaObject> ("getInstance");
						}
				}));
				
		}

		public static void start ()
		{
				if (Application.platform != RuntimePlatform.Android)
						return;
				_activity.Call ("runOnUiThread", new AndroidJavaRunnable (() =>
				{
						_plugin.Call ("start", _activity);
				}));
				
		}

		public static void setLocationQuantity (int location, int mNumber)
		{
				if (Application.platform != RuntimePlatform.Android)
						return;
				
				_plugin.Call ("setLocationQuantity", location, mNumber);
		}

		public static void activityStart ()
		{
				if (Application.platform != RuntimePlatform.Android) {
						return;
				}
				_activity.Call ("runOnUiThread", new AndroidJavaRunnable (() =>
				{
				
						_plugin.Call ("activityStart", _activity);
				}));
		}

		public static void activityStart (int mode)
		{
				if (Application.platform != RuntimePlatform.Android) {
						return;
				}
				_activity.Call ("runOnUiThread", new AndroidJavaRunnable (() =>
				{
					
						_plugin.Call ("activityStart", _activity, mode);
				}));
				
		}
		
		public static void activityStop ()
		{
				if (Application.platform != RuntimePlatform.Android)
						return;
				_activity.Call ("runOnUiThread", new AndroidJavaRunnable (() =>
				{
						_plugin.Call ("activityStop", _activity);
				}));
				
		}

		public static void setTimeChestAnimation (bool isAutomaticAnimation)
		{
				if (Application.platform != RuntimePlatform.Android)
						return;
				_activity.Call ("runOnUiThread", new AndroidJavaRunnable (() =>
				{
						_plugin.Call ("setTimeChestAnimation", isAutomaticAnimation);
				}));
				
		}

		public static void gotoAppList (int newCount)
		{
				if (Application.platform != RuntimePlatform.Android) {
						return;
				}
				_activity.Call ("runOnUiThread", new AndroidJavaRunnable (() =>
				{
			
						_plugin.Call ("gotoAppList", _activity, newCount);
				}));
		}

		public static void setGooglePlayApp ()
		{
				if (Application.platform != RuntimePlatform.Android)
						return;
				_activity.Call ("runOnUiThread", new AndroidJavaRunnable (() =>
				{
						_plugin.Call ("setGooglePlayApp");
				}));
			
		}

		public static void setShowPictureAd (bool show)
		{
				if (Application.platform != RuntimePlatform.Android)
						return;
				_activity.Call ("runOnUiThread", new AndroidJavaRunnable (() =>
				{
						_plugin.Call ("setShowPictureAd", show);
				}));
			
		}

		public static void setShowAppList (bool show)
		{
				if (Application.platform != RuntimePlatform.Android)
						return;
				_activity.Call ("runOnUiThread", new AndroidJavaRunnable (() =>
				{
						_plugin.Call ("setShowAppList", show);
				}));
			
		}
	
}