using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Score : MonoBehaviour
{
    public static int ScorePT;
    public Text ScoreText;
  
    private void Awake()
    {
        
;        ScoreText = GetComponent<Text>();
        ScorePT = 0;
    }
    // Update is called once per frame
    void WinGame()
    {
        if (ScorePT >= 3)
        {
            SceneManager.LoadScene("EndingScreen");

        }
    }
    void Update()
    {
       ScoreText.text = "Point(s): " + ScorePT;
        WinGame();
    }

 
}
