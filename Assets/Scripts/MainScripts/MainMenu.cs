using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    public void OnePlayerGame()
    {
        SceneManager.LoadScene("Scenes/Map0/TestingGround");
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
