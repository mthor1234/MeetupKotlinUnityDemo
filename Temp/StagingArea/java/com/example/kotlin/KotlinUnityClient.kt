package com.example.kotlin

import android.app.Activity
import android.content.Intent
import android.util.Log

/**
 * Created by MJ Thornton
 * 2019-07-09
 * Used to talk to Unity
 */
class KotlinUnityClient {
    internal var UNITYTAG = "Unity"

    fun calledFromUnity() {
        Log.d(UNITYTAG, "Successfully called from unity")
    }
}