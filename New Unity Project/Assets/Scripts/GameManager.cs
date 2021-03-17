using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static bool gameHasEnded = false;
    [SerializeField] private float restartDelay = 1f;

    public void EndGame()
    {
        if (gameHasEnded == false)
        {
            gameHasEnded = true;
            Time.timeScale = 0;

        }        
    }

    public void Restart()
    {
        SnowballCounter.snowballAmount = 0;
        Health.health = 10;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
