using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using TMPro;

public class Collisionwithobj : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    private int score = 0;
    void Start()
    {
        score = 0;
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("food"))
        {
            Destroy(gameObject);
            score += 5;
            scoreText.text = score.ToString();
        }
    }
}
