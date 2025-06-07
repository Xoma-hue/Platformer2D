using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinUI : MonoBehaviour
{
    public Text scoreText;
    private int score = 0;

    void Start()
    {
        UpdateScoreText();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Coin"))
        {
            score++;
            UpdateScoreText();
            Destroy(collision.gameObject);
        }
    }

    void UpdateScoreText()
    {
        scoreText.text = score.ToString();
    }
}
