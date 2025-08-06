using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    [HideInInspector]
    public Slider slider;

    [HideInInspector]
    public Gradient gradient;
    [HideInInspector]
    public Image fill;


    public void SetMaxHealth(int health)
    {
        slider.maxValue = health;
        slider.value = health;

        fill.color = gradient.Evaluate(1f);
    }

    public void SetHealth(int health)
    {
        slider.value = health;
        fill.color = gradient.Evaluate(slider.normalizedValue);
    }
}
