using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MENUGERAL : MonoBehaviour
{
   public void Jogar() 
   {
     SceneManager.LoadScene(1); // colocar level a ser carregado
   }
 
}
