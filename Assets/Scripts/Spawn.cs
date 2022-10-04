using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject inimigo1;
    public GameObject inimigo2;
    public GameObject inimigo3;
    public GameObject item1;

    public float tempo = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Temporizador();
    }

    void CriarInimigo1()
    {
        float posX = Random.Range(-2, 2);
        Vector3 posInicial = new Vector3(posX, 6, 0);
        GameObject ini1 = Instantiate(inimigo1,posInicial,Quaternion.identity);      
    }

    void CriarInimigo2()
    {
        float posX = Random.Range(-2, 2);
        Vector3 posInicial = new Vector3(posX, 6, 0);
        GameObject ini2 = Instantiate(inimigo2, posInicial, Quaternion.identity);
    }
    void CriarInimigo3()
    {
        float posX = Random.Range(-2, 2);
        Vector3 posInicial = new Vector3(posX, 6, 0);
        GameObject ini3 = Instantiate(inimigo3, posInicial, Quaternion.identity);
    }
    void CriarItem1()
    {
        float posX = Random.Range(-2, 2);
        Vector3 posInicial = new Vector3(posX, 6, 0);
        GameObject ini = Instantiate(item1, posInicial, Quaternion.identity);
    }
    void Temporizador()
    {
        tempo += Time.deltaTime;
        if(tempo > 1)
        {
            tempo = 0;
            float chance = Random.Range(0,10);
            if(chance <= 3)
            {
                CriarItem1();
            }
            else if(chance <= 5)
            {
                CriarInimigo1();
            }
            else if (chance <= 7)
            {
                CriarInimigo2();
            }
            else if (chance <= 9)
            {
                CriarInimigo3();
            }
        }
    }
}
