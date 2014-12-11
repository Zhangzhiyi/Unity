package com.zwayen.testunity3d;

import java.util.HashMap;
import java.util.Map.Entry;

import android.util.Log;

public class TestPassValue {
	public static final String TAG = "TestPassValue";
	public static void receiveHashMap(HashMap<String, String> map){
		Log.i(TAG, "receiveHashMap");
		for (Entry<String, String> entry: map.entrySet()) {
		    String key = entry.getKey();
		    String value = entry.getValue();
		    Log.i(TAG, "key:" + key + " value:" + value);
		}
	}
	public static void receiveString(String str){
		Log.i(TAG, "str:" + str);
	}
}
