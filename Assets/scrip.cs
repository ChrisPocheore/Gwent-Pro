using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class scrip : MonoBehaviour
{
   public void juga()
    {


        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);




    }

    public void Sali()
    { 

        Application.Quit();






    }
}
