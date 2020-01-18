using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour
{
    
    public GameObject pause;
    public static bool ispaused = false;
    public void PausePress()
    {
        if (ispaused == false)
        {
            pause.SetActive(true);
            Time.timeScale = 0;
            ispaused = true;
            Debug.Log("Game Paused");
        }
    }

    public void PlayPressed()
    {
        if (ispaused)
        {
            pause.SetActive(false);
            Time.timeScale = 1;
            Debug.Log("Play Pressed");
            ispaused = false;
        }
    }
    public void QuitGame()
    {
        Application.Quit();
    }


}
