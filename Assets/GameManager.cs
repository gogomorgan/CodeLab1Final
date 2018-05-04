using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.IO;

public class GameManager : MonoBehaviour {

    public static GameManager instance = null;

    public int score = 0;
    public int highScore = 0;

    // Use this for initialization
    void Awake () {

        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }

        if (PlayerPrefs.HasKey("HighScoreOnDisk"))
        {
            highScore = PlayerPrefs.GetInt("HighScoreOnDisk");
        }

        File.WriteAllText("TEST.txt", "THIS IS A TEST");

    }

    public void endGame()
    {
        if (score > highScore)
        {
            highScore = score;
            PlayerPrefs.SetInt("HighScoreOnDisk", highScore);
            PlayerPrefs.Save();
        }

        SceneManager.LoadScene("gameover");
    }

    

    // Update is called once per frame
    void Update () {

    }
}
