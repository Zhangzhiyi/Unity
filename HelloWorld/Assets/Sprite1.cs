using UnityEngine;
using System.Collections;

public class Sprite1 : MonoBehaviour {

	void Awake(){
		print ("Sprite1========>Awake");
	}
	// Use this for initialization
	void Start () {
		print ("Sprite1========>Start");
	}
	
	// Update is called once per frame
	void Update () {
		//print ("Sprite1========>Update");
	}

	void OnDestroy(){
		print ("Sprite1========>OnDestroy");
	}
	void OnApplicationPause (bool pauseStatus)
	{
		print ("Sprite1========>OnApplicationPause:" + pauseStatus);
	}
	void OnApplicationQuit(){
		print ("Sprite1========>OnApplicationQuit");
	}
}
