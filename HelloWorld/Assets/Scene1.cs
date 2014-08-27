using UnityEngine;
using System.Collections;

public class Scene1 : MonoBehaviour
{
		void Awake ()
		{
				print ("Scene1========>Awake");
				
				AdSdk.start ();
		}

		void OnDestroy ()
		{
				print ("Scene1========>OnDestroy");
		}
		void OnApplicationPause (bool pauseStatus)
		{
			print ("Scene1========>OnApplicationPause:" + pauseStatus);
			if(pauseStatus){
				AdSdk.activityStop ();
			}else{
				AdSdk.setLocationQuantity(3,2);
				AdSdk.activityStart(); // 右侧应用列表推荐形式广告 
				AdSdk.setTimeChestAnimation(true);
			}
			
		}
		void OnApplicationQuit ()
		{
				print ("Scene1========>OnApplicationQuit");
		}
		// Use this for initialization
		void Start ()
		{		
				
				print ("Scene1========>Start");
				#if UNITY_EDITOR
					Debug.Log("Unity Editor");
				#endif
		
				#if UNITY_IPHONE
					Debug.Log("Unity Iphone");
				#endif
				
				#if UNITY_ANDROID
					Debug.Log("Unity Android");
				#endif

				AdSdk.setLocationQuantity(3,2);
				AdSdk.activityStart(); // 右侧应用列表推荐形式广告 
				AdSdk.setTimeChestAnimation(true);
		
	}
	
	// Update is called once per frame
		void Update ()
		{
			
		}

		void OnGUI ()
		{
				if (GUILayout.Button ("Start TestActivity1", GUILayout.Width (200), GUILayout.Height (50))) {
						Debug.Log ("Start TestActivity1!");
						if (Application.platform != RuntimePlatform.Android)
								return;
						#if UNITY_ANDROID
							AndroidJavaClass jc = new AndroidJavaClass("com.unity3d.player.UnityPlayer");
							AndroidJavaObject jo = jc.GetStatic<AndroidJavaObject>("currentActivity");
							jo.Call("statrTestActivity1");

						#endif

				}
				if (GUILayout.Button ("Start TestActivity2", GUILayout.Width (200), GUILayout.Height (50))) {
						Debug.Log ("Start TestActivity2!");
						if (Application.platform != RuntimePlatform.Android)
								return;
						#if UNITY_ANDROID
							AndroidJavaClass jc = new AndroidJavaClass("com.unity3d.player.UnityPlayer");
							AndroidJavaObject jo = jc.GetStatic<AndroidJavaObject>("currentActivity");
							jo.Call("statrTestActivity2");
						#endif
				}
				if (GUILayout.Button ("Start TestActivity3", GUILayout.Width (200), GUILayout.Height (50))) {
						Debug.Log ("Start TestActivity3!");
						if (Application.platform != RuntimePlatform.Android)
								return;
						#if UNITY_ANDROID
							AndroidJavaClass jc = new AndroidJavaClass("com.unity3d.player.UnityPlayer");
							AndroidJavaObject jo = jc.GetStatic<AndroidJavaObject>("currentActivity");
							AndroidJavaClass jc2 = new AndroidJavaClass("com.zwayen.testunity3d2.StatciClass");
							jc2.CallStatic("startActivity3", jo);
						#endif
				}

		}

}
