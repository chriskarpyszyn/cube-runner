using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    public GameObject completeLevelUI;
    bool gameHasEnded = false;
    public float restartDelay = 2f;

    public void CompleteLevel()
    {
        completeLevelUI.SetActive(true);
    }

    public void EndGame()
    {

        if (gameHasEnded == false)
        {
            gameHasEnded = true;

            //todo-ck end game screen
            Debug.Log("GAME OVER");

            Invoke("Restart", restartDelay);
        }
    }

    void Restart()
    {
        // SceneManager.LoadScene("Level01");

        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

}
