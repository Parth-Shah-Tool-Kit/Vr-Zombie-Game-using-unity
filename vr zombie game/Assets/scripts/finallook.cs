using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class finallook : MonoBehaviour
{
    int a = 0;
    public void look(float po)
    {
           transform.Rotate(0,po,0);
           a += 1;
           if(a == 500)
           {
               SceneManager.LoadScene("intro");
           }
            
    }        
}