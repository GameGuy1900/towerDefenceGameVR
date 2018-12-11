using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class gameMaker : MonoBehaviour {

    bool gameHasEnded = false;
    public float restartDelay;

    public GameObject gameOverText;

    public void EndGameText()
	{
        gameOverText.SetActive(true);
	}

    public void EndGame()
    {
        if (gameHasEnded == false)
        {
            EndGameText();
            gameHasEnded = true;    
            Invoke("Restart", restartDelay);
        }
    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
	
}
