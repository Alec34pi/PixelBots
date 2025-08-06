using UnityEngine;
using UnityEngine.SceneManagement;

public class DontDestroyOnLoadScene : MonoBehaviour
{
    
    public GameObject[] objects;

    [HideInInspector]
    public static DontDestroyOnLoadScene instance;

    private void Awake()
    {
        if(instance != null)
        {
            Debug.LogWarning("Il y a plusieurs instance de DontDestroyOnLoadScene dans la scène !");
            return;
        }

        instance = this;

        foreach(var element in objects)
        {
            DontDestroyOnLoad(element);
        }
    }

    public void RemoveFromDontDestryOnLoad()
    {
        foreach(var element in objects)
        {
            SceneManager.MoveGameObjectToScene(element, SceneManager.GetActiveScene());
        }
    }
}
