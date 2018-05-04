using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class RestartScript : MonoBehaviour {

    public void restart()
    {
        Debug.Log("restart!!!");
        SceneManager.LoadScene(0);
    }
}
