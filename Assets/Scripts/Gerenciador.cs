using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class Gerenciador : MonoBehaviour
{
    [HideInInspector]
    public bool JogoLigado;
    Monetization monetization;
    Player player;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();
        Time.timeScale = 1f;
        JogoLigado = true;
        monetization = FindObjectOfType<Monetization>();
    }

    // Update is called once per frame
    void Update()
    {
        //Monetization
        CheckAdsIsReady();
    }

    public void CheckAdsIsReady()
    {
        /*
        uiControl.quests.GetComponent<Button>().interactable = monetization.InterstitialIsReady();
        uiControl.continueADS.GetComponent<Button>().interactable = monetization.RewardedIsReady();
        */
    }

    public void ContinueGame()
    {

    }
    public void OnInterstatialButtonClick()
    {
        monetization.ShowInterstitial();
    }

    public void OnRewardedButtonClick() //Continuar partida
    {
        monetization.ShowRewarded();
    }

    public void CarregarCena(int cena)
    {
        SceneManager.LoadScene(cena);
    }

    public void PausarJogo()
    {
        Time.timeScale = 0f;
        JogoLigado = false;
    }
    public void DespausarJogo()
    {
        JogoLigado = true;
        Time.timeScale = 1f;
    }
    public void SairJogo()
    {
        Debug.Log("Saiu");
        Application.Quit();
    }
}