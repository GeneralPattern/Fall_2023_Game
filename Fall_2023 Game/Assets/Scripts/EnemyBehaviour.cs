using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyBehaviour : MonoBehaviour
{
    public IntData enemy;
    public Slider enemyHealthSlider;
    public Text enemyHealthDisplay;
    public int maxHealth = 40; // Set your desired maximum health
    public int minHealth = 0;   // Set your desired minimum health

    void Start()
    {
        // Initialize enemy health within the specified range
        enemy.enemyHealth = Mathf.Clamp(enemy.enemyHealth, minHealth, maxHealth);

        // Set the max value of the slider to the initial enemy health range
        enemyHealthSlider.maxValue = maxHealth;
        enemyHealthSlider.minValue = minHealth;
    }

    void Update()
    {
        // Update the slider value based on the current enemy health
        enemyHealthSlider.value = Mathf.Clamp(enemy.enemyHealth, minHealth, maxHealth);

        // Optionally, update the text display
        enemyHealthDisplay.text = "Enemy Health: " + enemy.enemyHealth.ToString();
    }
}
