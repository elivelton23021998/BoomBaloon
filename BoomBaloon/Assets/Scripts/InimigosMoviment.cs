using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InimigosMoviment : MonoBehaviour
{
    GameObject[] vel;
    Rigidbody2D rb;
    float velocidade=-3;
    // Start is called before the first frame update
    void Start()
    {
        
        rb = GetComponent<Rigidbody2D>();
        vel=GameObject.FindGameObjectsWithTag("GameController");
        for (int i = 0; i < vel.Length; i++)
        {
            velocidade -= vel[i].GetComponent<GameMananger>().cont;
        }
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 move = new Vector2(0, velocidade);
        rb.velocity = move;
    }
    

}
