using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

    public void StartGame()
    {
        SceneManager.LoadScene("Zombie Shooter Level 1");
    }
    
    public void ExitGame()
    {
        Application.Quit();
    }
}
