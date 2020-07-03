using UnityEngine;
using UnityEngine.UI;

public class score : MonoBehaviour
{
    public Text scoreText;
    private int b = 0;
    void Update()
    {
     scoreText.text = b.ToString("0");   
    }

    public void trya(int a)
    {
        b = a;
    }
}
