using UnityEngine.SceneManagement;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    bool isOver = false;
    public float restartTiming = 2f;

    public GameObject fallText; // Reference to the welcome text GameObject
    private bool fallTextVisible = false;


    public void endGame()
    {
        if (isOver == false)
        {
            isOver = true;
            Debug.Log("gameover");

            // then can restart
            if (fallTextVisible == false)
            {
                fallText.SetActive(true);
                fallTextVisible = true;
            }
            Invoke("Restart", restartTiming);
        }
    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}

