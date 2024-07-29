using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public GameObject menu;
    public string gameSceneName;

    public void playGame()
    {
        menu.SetActive(false);
        SceneManager.LoadScene(gameSceneName);
    }
}
