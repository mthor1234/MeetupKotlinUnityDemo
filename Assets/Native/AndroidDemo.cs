//#if UNITY_ANDROID && !UNITY_EDITOR
using System;
using UnityEngine.UI;
using UnityEngine;
using JetBrains.Annotations;
using System.Runtime.InteropServices;

namespace TapThere.Chat
{
    public class AndroidDemo : MonoBehaviour{

        private static string JAVAUNITYCLIENTPACKAGENAME = "com.example.kotlinuntiy.JavaUnityClient";
        private static string KOTLINUNITYCLIENTPACKAGENAME = "com.example.kotlin.KotlinUnityClient";


        /** 
        <summary>
           AndroidJavaObject is needed to reference the Native Unity-Client
        </summary>
        */
        private static AndroidJavaObject unityClient;
        private static string _gameObjectName;

        #region Native code

        public void StartMainActivity()
        {
            unityClient = new AndroidJavaObject(JAVAUNITYCLIENTPACKAGENAME);
            AndroidJavaClass androidPlayerClass = new AndroidJavaClass("com.unity3d.player.UnityPlayer");
            AndroidJavaObject unityActivity = androidPlayerClass.GetStatic<AndroidJavaObject>("currentActivity");
            unityClient.CallStatic("startMainActivity", unityActivity, "Called from Unity!");
        }

        public void CallKotlinSource()
        {
            using (AndroidJavaObject jo = new AndroidJavaObject(KOTLINUNITYCLIENTPACKAGENAME))
            {
                jo.Call("calledFromUnity");
            }

        }
    }
}

#endregion

//#endif