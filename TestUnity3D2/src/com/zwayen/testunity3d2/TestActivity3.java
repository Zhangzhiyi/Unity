package com.zwayen.testunity3d2;

import android.app.Activity;
import android.os.Bundle;


public class TestActivity3 extends Activity {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        int layoutId = getResources().getIdentifier("test_activity3", "layout", getPackageName());
        setContentView(layoutId);
    }
}
