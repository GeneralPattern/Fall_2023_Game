using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]

public class Card : MonoBehaviour
{
    public int id;
    public string cardName;
    public int cost;

    public int power;

    public string description;

    public Card()
    {
        
    }

    public Card(int Id, string CardName, int Cost, int Power, string Description)
    {
        id = Id;
        cardName = CardName;
        cost = Cost;
        power = Power;
        description = Description;
    }
}
