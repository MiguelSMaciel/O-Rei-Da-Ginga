using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    public Rigidbody2D rig;
    public float speed;

    void FixedUpdate()
    {
        rig.MovePosition(transform.position + Vector3.down * speed * Time.deltaTime);
        Destroy(gameObject, 6f);
    }
}
