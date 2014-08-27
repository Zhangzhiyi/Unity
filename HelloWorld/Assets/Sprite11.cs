using UnityEngine;
using System.Collections;

public class Sprite11 : MonoBehaviour {
	
	void Awake(){
		print ("Sprite11========>Awake");
	}
	// Use this for initialization
	void Start () {
		print ("Sprite11========>Start");
	}
	
	// Update is called once per frame
	void Update () {
		//print ("Sprite11========>Update");
	}
	
	void OnDestroy(){
		print ("Sprite11========>OnDestroy");
	}
	void OnApplicationPause (bool pauseStatus)
	{
		print ("Sprite11========>OnApplicationPause:" + pauseStatus);
	}
	void OnApplicationQuit(){
		print ("Sprite11========>OnApplicationQuit");
	}
}
