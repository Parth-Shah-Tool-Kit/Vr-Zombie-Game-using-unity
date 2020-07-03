using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class targetintro : MonoBehaviour
{
    public float health = 10f;

    public void TakeDamage(float amount)
    {
        health -= amount;
        if (health <= 0f)
        {
            SceneManager.LoadScene("one");
            Die();
        }
    }
    void Die()
    {
        Destroy(gameObject);
    }
}
