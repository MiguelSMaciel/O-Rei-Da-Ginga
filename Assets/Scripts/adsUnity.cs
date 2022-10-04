using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Advertisements;

public class adsUnity : MonoBehaviour, IUnityAdsListener
{
    string placement = "Rewarded_Android";

    // Start is called before the first frame update
    void Start()
    {
        Advertisement.AddListener(this);
        Advertisement.Initialize("4949227", true);      
    }

    public void ShowAd(string p)
    {
        Advertisement.Show(p);
    }
    public void OnUnityAdsDidFinish(string placementId, ShowResult showResult)
    {
        if(showResult == ShowResult.Finished)
        {
            GameObject GMO = GameObject.FindGameObjectWithTag("GameController");
            Gerenciador GM = GMO.GetComponent<Gerenciador>();
            GM.ContinueGame();
        }
        else if (showResult == ShowResult.Failed)
        {
            // Oh no!
        }
    }

    public void OnUnityAdsDidStart(string placementId)
    {

    }

    public void OnUnityAdsReady(string placementId)
    {
  
    }
    public void OnUnityAdsDidError(string message)
    {

    }
}
