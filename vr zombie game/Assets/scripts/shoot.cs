using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shoot : MonoBehaviour
{   
    public GameObject theaudio;
    public GameObject thetext;
    public float damage = 10f;
    public float range = 10000f;
    public Camera fpsCam;
    int a = 0;
    void Update()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
    }
    void Shoot()
    {
        RaycastHit hit;
        if (Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward, out hit, range))
        {
            Target target = hit.transform.GetComponent<Target>();
            score sc = thetext.transform.GetComponent<score>();
            
            if (target != null) 
            {
                target.TakeDamage(damage);
                a += 1;
                sc.trya(a);  
            }
        }
        StartCoroutine(audio());
    }
    IEnumerator audio()
    {
        Instantiate(theaudio, new Vector3(100000f, 1000000f, 10000f), Quaternion.identity);
        yield return new WaitForSeconds(1f);
    }
}
