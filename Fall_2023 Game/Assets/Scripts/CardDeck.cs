using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using UnityEngine;

public class CardDeck : MonoBehaviour
{
    public CardList cardList;
    public CardList handList;

    void Start()
    {
        if (cardList.cardData != null && cardList.cardData.Count > 0)
        {
            for (int i = 0; i < 5; i++)
            {
                // Get a random index
                int randomIndex = Random.Range(0, cardList.cardData.Count);

                // Get the random CardData
                CardData randomCardData = cardList.cardData[randomIndex];

                // Use the random CardData
                Debug.Log("Random CardData: " + randomCardData.name + ", Value: " + randomCardData.cardID);

                // Add the random CardData to the HandList
                AddToHand(randomCardData, randomIndex);
            }
        }
        else
        {
            Debug.LogWarning("CardData list is empty. Make sure to assign CardData objects to the CardList.");
        }
    }

    private void AddToHand(CardData card, int indexToRemove)
    {
        // Check if the HandList is not null
        if (handList != null)
        {
            // Check if the list is null and create a new list if needed
            if (handList.cardData == null)
            {
                handList.cardData = new List<CardData> { card };
            }
            else
            {
                if (handList.cardData.Count < 5)
                {
                    // Add the card to the HandList
                    handList.cardData.Add(card);
                }
            }
        }
        else
        {
            Debug.LogWarning("HandList is null. Make sure to assign HandList in the inspector.");
        }
    }
    
}
