using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class scene : MonoBehaviour {

    public void BackMenu()
    {
        SceneManager.LoadScene(0);
        //string[] testDeviceIDs = new string[] { "E92E9A6745B85439C2EA180AB0010A87" };
        //EasyGoogleMobileAds.GetInterstitialManager().SetTestDevices(true, testDeviceIDs);
        EasyGoogleMobileAds.GetInterstitialManager().PrepareInterstitial("ca-app-pub-5824217627914801/5284446976");
        EasyGoogleMobileAds.GetInterstitialManager().ShowInterstitial();
    }
}
