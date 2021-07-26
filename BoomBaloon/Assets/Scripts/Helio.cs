using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Helio : MonoBehaviour
{
    public GameObject helio;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Spawn());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator Spawn()
    {
        yield return new WaitForSeconds(10f);
        float x = Random.Range(-1.9f, 1.9f);
        Vector3 posicao = transform.position;
        posicao.x += x;
        Instantiate(helio, posicao, transform.rotation);
        StartCoroutine(Spawn());

    }
}
