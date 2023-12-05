using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class EnemyBehaviour : MonoBehaviour
{
    public IntData gold;
    public IntData enemy;
    public Slider enemyHealthSlider;
    public Text enemyHealthDisplay;
    public int maxHealth = 10; 
    public int minHealth = 0;

    public UnityEvent winGame;
    

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

        if (enemy.enemyHealth <= 0)
        {
            WinRound();
        }
    }

    public void WinRound()
    {
        StartCoroutine(DisplayTextAndLoadScene());
    }

    private IEnumerator DisplayTextAndLoadScene()
    {
        winGame.Invoke();

        yield return new WaitForSeconds(3f);

        gold.value += 30;

        enemy.enemyHealth += 5;

        maxHealth += 5;

        SceneManager.LoadScene("StartMenu");
    }
}
