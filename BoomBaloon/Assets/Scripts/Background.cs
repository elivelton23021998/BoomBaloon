using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Background : MonoBehaviour
{
    Rigidbody2D rb;
    public float velocidade;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

    }

    void Update()
    {
        Vector2 move = new Vector2(0, velocidade);
        rb.velocity = move;

    }


}
