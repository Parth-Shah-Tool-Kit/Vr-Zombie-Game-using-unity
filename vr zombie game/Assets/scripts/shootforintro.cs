using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shootforintro : MonoBehaviour
{   
    public GameObject theaudio;
    public Camera fpsCam;
    float damage = 10f;
    float range = 10000f;
    void Update()
    {
        if(Input.GetButtonDown("Fire1")){
            Shoot();
        }
    }
    void Shoot()
    {
        RaycastHit hit;
        if (Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward, out hit, range))
        {
            targetintro target = hit.transform.GetComponent<targetintro>();
           
            if (target != null) 
            {
                target.TakeDamage(damage);
                
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
