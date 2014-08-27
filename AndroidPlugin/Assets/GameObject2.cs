using UnityEngine;
using System.Collections;

public class GameObject2 : MonoBehaviour {
	
	void Awake(){
		print ("GameObject2========>Awake");
	}
	// Use this for initialization
	void Start () {
		print ("GameObject2========>Start");
	}
	
	// Update is called once per frame
	void Update () {
		//print ("GameObject2========>Update");
	}
	
	void OnDestroy(){
		print ("GameObject2========>OnDestroy");
	}
	void OnApplicationPause (bool pauseStatus)
	{
		print ("GameObject2========>OnApplicationPause:" + pauseStatus);
	}
	void OnApplicationQuit(){
		print ("GameObject2========>OnApplicationQuit");
	}
}