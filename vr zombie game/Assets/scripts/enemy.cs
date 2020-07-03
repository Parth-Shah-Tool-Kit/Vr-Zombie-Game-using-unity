using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{
    public GameObject theEnemy;
    public int xPos;
    public int zPos;
    public int count;
    private int a = 0;
    private int b = 40;
    void Update()
    {
      if (a % 700 == 0)
      {
        while (count <= b)
        {
          StartCoroutine(EnemyDrop());
          count += 1;
        } 
        b += 15;       
      }
      a += 1;
      count = 0;
      
    }

    IEnumerator EnemyDrop()
    {
        xPos = Random.Range(-133, 133);
        zPos = Random.Range(-133, 133);
        if (((xPos < -15)||(xPos > 15))&&((zPos < -15)||(zPos > 15)))  
          {
            Instantiate(theEnemy, new Vector3(xPos, 0.1f, zPos), Quaternion.identity);
          }
        yield return new WaitForSeconds(1f);
        
    }
}
