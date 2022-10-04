using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float HP;
    public int itens = 0;
    private Gerenciador GJ;
    public GameObject painelMorte;
    public GameObject vida1;
    public GameObject vida2;
    public GameObject vida3;
    // Start is called before the first frame update
    void Start()
    {
        GJ = GameObject.FindGameObjectWithTag("GameController").GetComponent<Gerenciador>();
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }
    void Move()
    {
        bool JL = GJ.JogoLigado;
        if (JL == true)
        {
        if (Input.GetMouseButton(0))
        {
            Vector3 posMouse = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector3 posPlayer = new Vector3(posMouse.x, transform.position.y, transform.position.z);
            transform.position = Vector3.MoveTowards(transform.position, posPlayer, 0.3f);
        }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Inimigo")
        {
            Destroy(collision.gameObject);
            HP -= 1;
            Destroy(collision.gameObject);
            if (HP == 2)
            {
                vida1.SetActive(false);
            }
            if (HP == 1)
            {
                vida2.SetActive(false);
            }
            if (HP == 0)
            {
                vida3.SetActive(false);
            }
            if (HP <= 0)
            {
                
                painelMorte.SetActive(true);
                GJ.PausarJogo();
                Debug.Log("PERDEU");
            }
        }
        if (collision.gameObject.tag == "Item")
        {
            Destroy(collision.gameObject);
            itens++;
        }
    }

    public void Reviver()
    {        
        HP = 3;
        vida1.SetActive(true);
        vida2.SetActive(true);
        vida3.SetActive(true);
        painelMorte.SetActive(false);
        GJ.DespausarJogo();
    }
}
