using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour {
    public Button curButton;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if(curButton.tag == "Finish")
        {
            curButton.onClick.RemoveAllListeners();
            curButton.onClick.AddListener(() => GameExit());
        }
        else if(curButton.tag == "Respawn")
        {
            curButton.onClick.RemoveAllListeners();
            curButton.onClick.AddListener(() => GameContinue());
        }
		
	}

    void GameExit()
    {
        Application.Quit();
        Debug.Log("Application Quits");
    }

    void GameContinue()
    {
        SceneManager.LoadScene("MainScene");
    }
}
