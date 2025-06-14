using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{

    // Метод для завантаження 1 рівня
    public void LoadLevel1()
    {
        SceneManager.LoadScene("Level1");  // Назва сцени 1-го рівня
    }

    // Метод для завантаження 2 рівня
    public void LoadLevel2()
    {
        SceneManager.LoadScene("Level2");  // Назва сцени 2-го рівня
    }

}
