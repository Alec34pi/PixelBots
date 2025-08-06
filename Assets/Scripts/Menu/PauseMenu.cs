using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public static bool gameIsPaused = false;

    public GameObject pausedMenuUI;

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            if(gameIsPaused)
            {
                Resume();
            } else
            {
                Paused();
            }
        }
    }

    void Paused()
    {
        PlayerMovement.instance.enabled = false;
        pausedMenuUI.SetActive(true);
        Time.timeScale = 0;
        gameIsPaused = true;
    }

    public void Resume()
    {
        PlayerMovement.instance.enabled = true;
        pausedMenuUI.SetActive(false);
        Time.timeScale = 1;
        gameIsPaused = false;
    }

    public void MainMenuButton()
    {
        DontDestroyOnLoadScene.instance.RemoveFromDontDestryOnLoad();
        Resume();
        SceneManager.LoadScene("MainMenu");
    }
}
