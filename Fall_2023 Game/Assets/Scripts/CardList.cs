using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Card List")]
public class CardList : ScriptableObject
{
    public List<CardData> cardData = new List<CardData>();

    public void RemCard(int idx)
    {
        Debug.Log("Attempt to remove");
        cardData.RemoveAt(idx);
        for (int i = 0; i < cardData.Count; i++)
        {
            Debug.Log(cardData[i].name);
        }
    }
}
