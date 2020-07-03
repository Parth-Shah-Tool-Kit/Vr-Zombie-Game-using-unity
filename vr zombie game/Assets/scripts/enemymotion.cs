using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemymotion : MonoBehaviour
{
    public GameObject player;
    public float speed = 1f;
    private Vector3 pos;
    void Update()
    {
        transform.LookAt(player.transform);
        pos = transform.position;
        if (((pos.x >= 0.5f)||(pos.x <= -0.5f))&&((pos.z >= 0.5f)||(pos.z <= -0.5f)))
        {
            transform.position += transform.forward * speed * Time.deltaTime;    
        }   
    }
}
