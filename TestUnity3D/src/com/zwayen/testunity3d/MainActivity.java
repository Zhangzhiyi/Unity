package com.zwayen.testunity3d;

import android.content.Intent;
import android.os.Bundle;
import android.util.Log;

import com.unity3d.player.UnityPlayerActivity;


public class MainActivity extends UnityPlayerActivity {
	
	public static final String TAG = "UnityPlayerActivity";
	@Override
	protected void onCreate(Bundle savedInstanceState) {
		// TODO Auto-generated method stub
		super.onCreate(savedInstanceState);
		Log.i(TAG, "onCreate");
	}
	
	public void statrTestActivity1(){
		Intent intent = new Intent(this, TestActivity1.class);
		startActivity(intent);
	}
	public void statrTestActivity2(){
		Intent intent = new Intent(this, TestActivity2.class);
		startActivity(intent);
	}
}
