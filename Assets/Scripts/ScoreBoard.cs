using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ScoreBoard : MonoBehaviour
{
    // Start is called before the first frame update
    public Text score;
    public int val;
    void Start()
    {
        val = 0;
        score.text = "Score : 0";
    }

    // Update is called once per frame
    void Update()
    {
        val= Mathf.RoundToInt(this.transform.position.y+39f);
        score.text = "Score : "+val;
        PlayerPrefs.SetInt("Score",val);
        if(val>PlayerPrefs.GetInt("HighScore",0)) {
            PlayerPrefs.SetInt("HighScore",val);
        }
        
    }
}
