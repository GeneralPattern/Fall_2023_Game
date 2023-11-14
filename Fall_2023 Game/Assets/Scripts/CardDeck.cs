using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardDeck : MonoBehaviour
{
    public CardList cardList;

    void Start()
    {
        int randomIndex = Random.Range(0, cardList.cardData.Length);

        // Get the random CardData
        CardData randomCardData = cardList.cardData[randomIndex];

        Debug.Log("Random CardData: " + randomCardData.name + ", Value: " + randomCardData.cardID);
        
        
        
    }

    
    void Update()
    {
        
    }
}
