using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class Display : MonoBehaviour
{
    public Text score;
    public int res;
    public Text HighScore;
    // Start is called before the first frame update

    void Start()
    {
        score.text = "Score : "+PlayerPrefs.GetInt("Score",0); 
        HighScore.text = "HIGH SCORE : "+PlayerPrefs.GetInt("HighScore",0);
    }

    public void OnClickStart() {

        SceneManager.LoadScene("Level");
    }
    public void OnApplicationQuit()
    {
        Application.Quit();
    }
}
