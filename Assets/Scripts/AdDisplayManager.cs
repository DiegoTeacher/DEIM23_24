using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Advertisements;

public class AdDisplayManager : MonoBehaviour, IUnityAdsLoadListener, IUnityAdsShowListener
{
    public string myGameIdAndroid = "5528680";
    public string adUnitIdAndroid = "Banner_Android";

    public string myAdUnitId;
    public bool testMode = true;

    public static AdDisplayManager instance;

    public MeshRenderer _rend;

    private void Awake()
    {
        if (!instance)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        Advertisement.Initialize(myGameIdAndroid, testMode);
        myAdUnitId = adUnitIdAndroid;
    }

    public void ShowAd()
    {
        if (Advertisement.isInitialized)
        {
            Advertisement.Load(myAdUnitId);
            Advertisement.Show(myAdUnitId);
        }
    }

    public void OnUnityAdsShowStart(string placementId)
    {
        throw new System.NotImplementedException();
    }

    public void OnUnityAdsShowClick(string placementId)
    {
        throw new System.NotImplementedException();
    }

    public void OnUnityAdsShowComplete(string placementId, UnityAdsShowCompletionState showCompletionState)
    {
        _rend.material.color = Color.red;
    }

    public void OnUnityAdsAdLoaded(string placementId)
    {
        _rend.material.color = Color.black;
    }

    public void OnUnityAdsFailedToLoad(string placementId, UnityAdsLoadError error, string message)
    {
        _rend.material.color = Color.cyan;
    }

    public void OnUnityAdsShowFailure(string placementId, UnityAdsShowError error, string message)
    {
        throw new System.NotImplementedException();
    }
}