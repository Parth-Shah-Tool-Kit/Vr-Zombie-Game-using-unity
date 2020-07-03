using UnityEngine;

public class Target : MonoBehaviour
{
    public float health = 10f;
    private Vector3 pos;
    public GameObject theplayer;
    public GameObject Manager;
    public GameObject Manager2;
    public GameObject theaudio;
    private float a = 1.0f;
    void Update()
    {
        pos = transform.position;
        if (((pos.x <= 1f)&&(pos.x >= -1f))&&((pos.z <= 1f)&&(pos.z >= -1f)))
        {
            finallook play = theplayer.transform.GetComponent<finallook>();
            play.look(a);
            theaudio.SetActive(true);
            Manager.SetActive(false);
            Manager2.SetActive(true);
        }
        
    }

    public void TakeDamage(float amount)
    {
        health -= amount;
        if (health <= 0f)
        {
            Die();
        }
    }
    void Die()
    {
        Destroy(gameObject);
    }
}
