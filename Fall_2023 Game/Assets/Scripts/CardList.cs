using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Card List")]
public class CardList : ScriptableObject
{
    public List<CardData> cardData = new List<CardData>();
}
