using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Card List")]
public class CardList : ScriptableObject
{
    public CardData[] cardData;
}
