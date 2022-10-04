using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UI_HighScore : MonoBehaviour
{
    private Player player;
    public TMP_Text textScore;
    public TMP_Text HighScore;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();
        HighScore.text = PlayerPrefs.GetInt("HighScore",0).ToString();
    }

    // Update is called once per frame
    void Update()
    {
        int score = player.itens;
        textScore.text = score.ToString();
        if(score > PlayerPrefs.GetInt("HighScore", 0))
        {
            PlayerPrefs.SetInt("HighScore", score);
            HighScore.text = score.ToString();
        }
    }
}
