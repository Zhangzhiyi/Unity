package com.zwayen.testunity3d;

import android.app.Activity;
import android.os.Bundle;
import android.util.Log;

public class TestActivity2 extends Activity {
	
	public static final String TAG = "TestActivity2";
	@Override
	protected void onCreate(Bundle savedInstanceState) {
		// TODO Auto-generated method stub
		super.onCreate(savedInstanceState);
		int layoutId = getResources().getIdentifier("test_activity2", "layout", getPackageName());
        setContentView(layoutId);
		Log.i(TAG, "onCreate");
	}
}
