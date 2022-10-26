using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bg_Movimento : MonoBehaviour
{
    public float speed;

    private MeshRenderer render;

    // Start is called before the first frame update
    void Start()
    {
        render = GetComponent<MeshRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        float posY = Mathf.Repeat(Time.deltaTime * speed,1);
        Vector2 offset = new Vector2(0, posY);
        render.sharedMaterial.SetTextureOffset("_MainTex", offset);
    }
}
