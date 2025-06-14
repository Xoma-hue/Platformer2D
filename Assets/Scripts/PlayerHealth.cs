using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;
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
            Destroy(gameObject);
            SceneManager.LoadScene("MainMenu");
        }
    }

    void UpdateHealthText()
    {
        healthText.text = "Health: " + health;
    }
}
