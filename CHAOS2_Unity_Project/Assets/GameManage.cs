using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManage : MonoBehaviour
{

    public static GameManage instance;
    bool gamehasEnded = false;

    public GameOver gameOver;

    public float restartDelay = 2f;

    void Start() {
        instance = this;
    }
    public void EndGame()
    {
        Debug.Log("Before if");
        Debug.Log(gamehasEnded);

        if (gamehasEnded == false)
        {
            Debug.Log("Game over");
            gamehasEnded = true;
            gameOver.SetPosition(200);


            Invoke("Restart", restartDelay);
        }
    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
