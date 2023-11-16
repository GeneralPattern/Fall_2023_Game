using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Store : MonoBehaviour
{
    public CardList deckList;
    public CardData storeItem;

    public void AddToDeck()
    {
        IList<CardData> cardList = deckList.cardData;
        
        // Use the IList.Add method to add an item
        cardList.Add(storeItem);
        
        Debug.Log("Add to deck");
    }
}
