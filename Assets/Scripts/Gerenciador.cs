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

    
    private bool audio_Ligado;
    [SerializeField] Image sOff;
    [SerializeField] Image sOnn;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();
        Time.timeScale = 1f;
        JogoLigado = true;
        monetization = FindObjectOfType<Monetization>();
        OnOff();
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

    public void AudioGame()
    {
        audio_Ligado = !audio_Ligado;
        if (audio_Ligado == true)
        {
            AudioListener.volume = 1;
        }
        else
        {
            AudioListener.volume = 0;
        }

        OnOff();
    }

    private void OnOff()
    {
        if(audio_Ligado == false)
        {
            sOnn.enabled = true;
            sOff.enabled = false;
        }
        else
        {
            sOnn.enabled = false;
            sOff.enabled = true;
        }
    }

    public void ContinueGame()
    {
        player.Reviver();
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
