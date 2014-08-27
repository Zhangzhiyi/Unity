using UnityEngine;
using System.Collections;

public class GameObject21 : MonoBehaviour {
	
	void Awake(){
		print ("GameObject21========>Awake");
	}
	// Use this for initialization
	void Start () {
		print ("GameObject21========>Start");
	}
	
	// Update is called once per frame
	void Update () {
		//print ("GameObject21========>Update");
	}
	
	void OnDestroy(){
		print ("GameObject21========>OnDestroy");
	}
	void OnApplicationPause (bool pauseStatus)
	{
		print ("GameObject21========>OnApplicationPause:" + pauseStatus);
	}
	void OnApplicationQuit(){
		print ("GameObject21========>OnApplicationQuit");
	}
}