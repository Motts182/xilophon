using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GamecontrollerScript : MonoBehaviour
{
    void Awake()
    {
        DontDestroyOnLoad(transform.gameObject);
    }

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void ChangeLevel() {
        SceneManager.LoadScene(1);
        string[] testDeviceIDs = new string[] { "E92E9A6745B85439C2EA180AB0010A87" };
        EasyGoogleMobileAds.GetInterstitialManager().SetTestDevices(true, testDeviceIDs);
        EasyGoogleMobileAds.GetInterstitialManager().PrepareInterstitial("ca-app-pub-5824217627914801/5284446976");
        EasyGoogleMobileAds.GetInterstitialManager().ShowInterstitial();
    }
}
