using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CastBehaviour : MonoBehaviour
{
    public CardData card;
    public IntData cast;
    public IntData enemy;
    public CardData caster;

    public IntData castedCount;
    public CardList handList;
    public Text diceRollText;

    private GameObject slotNo;
    
    
    


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
            cast.diceRoll = Random.Range(2, 13);
            cast.diceRoll += caster.castLevel;

            ShowDiceRollText();

            Invoke("HideDiceRollText", 1f);

            Cast();
        }
        else
        {
            Debug.Log("OUT OF SPELLS");
        }
    }

    private void ShowDiceRollText()
    {
        
        string resultText = "Dice Roll: " + cast.diceRoll + " - ";
        Debug.Log(cast.diceRoll);
        if (cast.diceRoll >= card.cost)
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
        if (cast.diceRoll >= card.cost)
        {
            enemy.enemyHealth -= card.damage;
            Debug.Log(enemy.enemyHealth);
            Debug.Log(card.name);
        }
        else
        {
            Debug.Log("Try again you filthy bastard");
        }

        castedCount.value += 1;
        Debug.Log(castedCount.value);
    }
}