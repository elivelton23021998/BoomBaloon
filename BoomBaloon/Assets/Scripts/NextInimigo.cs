using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextInimigo : MonoBehaviour
{
    public GameObject[] pedras;
    private int x;

    private void Start()
    {
        
    }
    private void OnTriggerExit2D(Collider2D collision)
    {

        if (collision.gameObject.CompareTag("Inimigos"))
        {
            
            x = Random.Range(0, pedras.Length);
            Vector3 posicao = transform.position;
            posicao.y += 8;
            Instantiate(pedras[x], posicao, transform.rotation);
        }
    }
}
