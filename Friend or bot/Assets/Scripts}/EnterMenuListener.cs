using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnterMenuListener : MonoBehaviour
{
 public void OptionsMenu() 
    {
        SceneManager.LoadSceneAsync(1);
    }
    public void PlayGame()
    {
        SceneManager.LoadSceneAsync(2);
    }
    public void QuitGame() 
    {
        Application.Quit();
    }
}
