using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    Rigidbody2D rb;
    AudioClip captura;
    float[] data;
    float media;
    public int coin;
    public GameObject highScore;

    void Start()
    {
        coin = 0;
        rb = GetComponent<Rigidbody2D>();
        captura = Microphone.Start(Microphone.devices[0], true, 1, 44100);
        data = new float[captura.samples / 20];
    }

    void Update()
    {

        //codigo pra transformar volume de som em numero
        int posicao = Microphone.GetPosition(Microphone.devices[0]);
        captura.GetData(data, Mathf.Clamp(posicao - data.Length, 0, captura.samples));
        media = 0;
        for (int i = 0; i < data.Length; i++)
        {
            media += Mathf.Abs(data[i]);
        }
        media /= data.Length / 5;

        //script de movimento

        if (media < 0.9) media = 0;
        Vector2 move = new Vector2(Input.acceleration.x * 5, media * 2);


        rb.velocity = move;


        //codigo para o tamanho
        Vector3 tamanho = new Vector3(transform.localPosition.x, transform.localPosition.x, transform.localPosition.x);


        transform.localScale = tamanho;

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Morte"))
        {
            GetComponent<AudioSource>().Play();
            
            StartCoroutine(Death());
        }
    }

    IEnumerator Death()
    {
        yield return new WaitForSeconds(0.4f);

        highScore.SetActive(true);
        Destroy(gameObject);

        //SceneManager.LoadScene(0);
    }
}
