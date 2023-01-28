using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool GameEnded = false;
    public float GameDelay = 1f;
    public GameObject completegameUI;

    public void CompleteLevel()
    {
        completegameUI.SetActive(true);
    }

   public void GameOver ()
    {
        if (GameEnded == false)
        {
            GameEnded = true;
            Debug.Log("GAME OVER");
            Invoke("Restart",GameDelay);
        }
       
    }

  void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    } 
}
