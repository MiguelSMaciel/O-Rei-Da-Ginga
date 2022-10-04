using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UI_Score : MonoBehaviour
{
    private Player player;
    private TMP_Text textoScore;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();
        textoScore = GetComponent<TMP_Text>();
    }

    // Update is called once per frame
    void Update()
    {
        textoScore.text = player.itens.ToString();
    }
}
