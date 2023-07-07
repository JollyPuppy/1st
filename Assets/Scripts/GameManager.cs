using UnityEngine.SceneManagement;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject completeLevelUI;

    public bool gameHasEnded = false;

    public float restartDelay = 1f;
    public void CompleteLevel()

    {
        Debug.Log("Level Won");
        completeLevelUI.SetActive(true);
    }
        
    public void EndGame()
    {
        if (gameHasEnded == false)
        {
            gameHasEnded = true;
            Debug.Log("Game Over");
            Invoke("Restart", restartDelay);
        }

    }

    private void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

}
