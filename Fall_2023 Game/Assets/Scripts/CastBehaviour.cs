using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class CastBehaviour : MonoBehaviour
{
    public UnityEvent threeSpellsLeft;
    public UnityEvent twoSpellsLeft;
    public UnityEvent oneSpellsLeft;
    public UnityEvent noSpellsLeft;

    public CardData card;
    public IntData cast;
    public IntData enemy;
    public CardData caster;
    
    public IntData castedCount;
    public CardList handList;
    public Text diceRollText;

    private GameObject slotNo;

    public DiceThrower diceThrower;


    public void CastCard(GameAction castAction)
    {
        castAction.raise();
    }

    public void SetCard(int data)
    {
        card = handList.cardData[data];
        //slotNo = GameObject("Card_0" + (5-data).ToString());
        Debug.Log(card.name);
        //Debug.Log(slotNo);
    }
    public void DiceRoll()
    {

        if (castedCount.value < caster.spellSlots)
        {
            StartCoroutine(RollDiceWithDelay());
        }
        else
        {
            Debug.Log("OUT OF SPELLS");
        }
    }
    
    private IEnumerator RollDiceWithDelay()
    {
        diceThrower.RollDice(); // Roll the dice

        yield return new WaitForSeconds(3f); // Wait for 2 seconds

        ShowDiceRollText(); // Show the text
        
        Invoke("HideDiceRollText", 2f);

        // Continue with the casting logic
        Cast(); 
    }

    private void ShowDiceRollText()
    {
        
        string resultText = "Dice Roll: " + cast.diceRoll + " - ";
        if (cast.diceRoll + caster.castLevel >= card.cost)
        {
            resultText += "Success!";
            
        }
        else
        {
            resultText += "Fail!";
            
        }
        Debug.Log(resultText);
        diceRollText.text = resultText;
        diceRollText.gameObject.SetActive(true);
    }

    private void HideDiceRollText()
    {
        diceRollText.gameObject.SetActive(false);
    }

    public void Cast()
    {
        if (cast.diceRoll + caster.castLevel >= card.cost)
        {
            enemy.enemyHealth -= card.damage;
            caster.health += card.healingNo;
            
        }
        else
        {
            
        }

        castedCount.value += 1;
    }

    private void Update()
    {
        if (castedCount.value == 1)
        {
            threeSpellsLeft.Invoke();
            
        }
        if (castedCount.value == 2)
        {
            twoSpellsLeft.Invoke();
            
        }
        if (castedCount.value == 3)
        {
            oneSpellsLeft.Invoke();
            
        }
        if (castedCount.value == 4)
        {
            
            StartCoroutine(DisplayTextAndLoadLoseScene());
        }
    }

    private IEnumerator DisplayTextAndLoadLoseScene()
    {
        noSpellsLeft.Invoke();

        yield return new WaitForSeconds(3f);

        SceneManager.LoadScene("StartMenu");
    }
}