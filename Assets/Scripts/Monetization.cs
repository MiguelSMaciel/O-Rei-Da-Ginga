using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Advertisements;

public class Monetization : MonoBehaviour, IUnityAdsListener
{
    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(this.gameObject);

        string gameID = "4949227";

        Advertisement.AddListener(this);
        Advertisement.Initialize(gameID, Debug.isDebugBuild);
    }

    public void ShowInterstitial()
    {
        Advertisement.Show("Interstitial_Android");
    }

    public bool InterstitialIsReady()
    {
        return Advertisement.IsReady("Interstitial_Android");
    }

    public void ShowRewarded()
    {
        Advertisement.Show("Rewarded_Android");
    }

    public bool RewardedIsReady()
    {
        return Advertisement.IsReady("Rewarded_Android");
    }

    public void OnUnityAdsReady(string placementId)
    {
        //Quando o video esta pronto
    }

    public void OnUnityAdsDidError(string message)
    {
        //Quando da algum erro ao carregar a propaganda
        Debug.Log("Erro: " + message);
    }

    public void OnUnityAdsDidStart(string placementId)
    {
        //Quando o video começa
    }

    public void OnUnityAdsDidFinish(string placementId, ShowResult showResult)
    {
        //Quando o video acaba
        if (placementId == "Rewarded_Android" && showResult == ShowResult.Finished)
        {
            GameObject GMO = GameObject.FindGameObjectWithTag("GameController");
            Gerenciador GM = GMO.GetComponent<Gerenciador>();
            GM.ContinueGame();
        }

        if (placementId == "Rewarded_Android" && showResult == ShowResult.Failed)
        {
            //Nada acontece
        }
    }
}
