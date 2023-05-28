using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
public class ObjectDestruction : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    private int score = 0;
    void Start()
    {
        score = 0;
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("obj"))
        {
            Destroy(gameObject);
            score += 5;
            scoreText.text = score.ToString();
        }
    }
}
