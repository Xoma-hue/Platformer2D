using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    public int health = 3;
    public Text healthText;

    void Start()
    {
        UpdateHealthText();
    }

    public void TakeDamage(int damage)
    {
        health -= damage;
        UpdateHealthText();

        if (health <= 0)
        {
            Debug.Log("Player Dead!");
            // Можна додати сцену поразки або респавн
            Destroy(gameObject);
        }
    }

    void UpdateHealthText()
    {
        healthText.text = "Health: " + health;
    }
}
