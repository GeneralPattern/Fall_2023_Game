using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CastBehaviour : MonoBehaviour
{
    public CardData card;
    public IntData cast;


    public void Cast()
    {
        if (card.cost < cast.diceRoll)
        {
            Debug.Log("CASTED BITCH");
        }
        else
        {
            Debug.Log("Try again you filthy bastard");
        }
    }

}
