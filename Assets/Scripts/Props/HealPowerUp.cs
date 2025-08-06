using UnityEngine;

public class HealPowerUp : MonoBehaviour
{
    public int HealthPoints;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            if(PlayerHealth.instance.currentHealth < PlayerHealth.instance.maxHealth)
            {
                PlayerHealth.instance.HealPlayer(HealthPoints);
                Destroy(gameObject);
            }
        }
    }
}
