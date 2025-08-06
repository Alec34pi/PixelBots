using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverManager : MonoBehaviour
{
    public GameObject gameOverUI;

    [HideInInspector]
    public static GameOverManager instance;

    private void Awake()
    {
        if(instance != null)
        {
            Debug.LogWarning("Il y a plusieurs instance de GameOverManager dans la scène !");
            return;
        }

        instance = this;
    }

    public void OnPlayerDeath()
    {
        if(CurrentSceneManager.instance.isPlayerPresentByDefault)
        {
            DontDestroyOnLoadScene.instance.RemoveFromDontDestryOnLoad();
        }
        gameOverUI.SetActive(true);
    }

    public void RetryButton()
    {
        Inventory.instance.RemoveCoins(CurrentSceneManager.instance.coinsPickedUpInThisSceneCount);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        PlayerHealth.instance.Respawn();
        gameOverUI.SetActive(false);
    }

    public void MainMenuButton()
    {
        DontDestroyOnLoadScene.instance.RemoveFromDontDestryOnLoad();
        SceneManager.LoadScene("MainMenu");
    }

    public void QuitButton()
    {
        Application.Quit();
    }
}
