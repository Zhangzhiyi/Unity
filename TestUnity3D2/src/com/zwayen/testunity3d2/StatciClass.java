package com.zwayen.testunity3d2;

import android.content.Context;
import android.content.Intent;
import android.util.Log;

public class StatciClass {
	public static final String TAG = "StatciClass";
	public static void startActivity3(Context context){
		Log.i(TAG, "startActivity3");
		Intent intent = new Intent(context, TestActivity3.class);
		context.startActivity(intent);
	}
}
