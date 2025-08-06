using UnityEngine;
using UnityEngine.UI;

public class Inventory : MonoBehaviour
{
    [HideInInspector]
    public int coinsCount;

    [HideInInspector]
    public static Inventory instance;

    [HideInInspector]
    public Text coinsCountText;

    private void Awake()
    {
        if(instance != null)
        {
            Debug.LogWarning("Il y a plusieurs instance de Invotory dans la scène !");
            return;
        }

        instance = this;
    }

    public void AddCoins(int count)
    {
        coinsCount += count;
        coinsCountText.text = coinsCount.ToString();
    }

    public void RemoveCoins(int count)
    {
        coinsCount -= count;
        coinsCountText.text = coinsCount.ToString();
    }
}
