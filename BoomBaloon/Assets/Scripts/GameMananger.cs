using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMananger : MonoBehaviour
{
    [HideInInspector]
    public int cont = 0;
    // Start is called before the first frame update
    void Start()
    {
        
        StartCoroutine(UpVelocity());
    }

    // Update is called once per frame
    void Update()
    {
      
    }
    IEnumerator UpVelocity()
    {
        yield return new WaitForSeconds(25);
        cont++;
        StartCoroutine(UpVelocity());

    }
}
