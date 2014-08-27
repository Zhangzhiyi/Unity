package com.zwayen.testunity3d;

import android.app.Activity;
import android.os.Bundle;
import android.util.Log;
import android.widget.TextView;

public class TestActivity1 extends Activity {
	
	public static final String TAG = "TestActivity1";
	@Override
	protected void onCreate(Bundle savedInstanceState) {
		// TODO Auto-generated method stub
		super.onCreate(savedInstanceState);
		int layoutId = getResources().getIdentifier("test_activity1", "layout", getPackageName());
        setContentView(layoutId);
		Log.i(TAG, "onCreate");
	}
}
