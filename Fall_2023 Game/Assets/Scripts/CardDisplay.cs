using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;


public class CardDisplay : MonoBehaviour
{
    public CardList handList;
    public int slotNumber;

    public Text nameText;
    public Text descriptionText;
    public Text castLevelText;

    public Image artworkImage;
    public Image cardImage;

    public Text costText;

    void Start()
    {
        DisplayFirstCard();
    }

    private void DisplayFirstCard()
    {
        // Ensure that the handList and its list are not null
        if (handList != null && handList.cardData != null && handList.cardData.Count > 0)
        {
            // Display the first card
            DisplayCard(handList.cardData[slotNumber]);
        }
        else
        {
            Debug.LogWarning("HandList or its cardData list is null or empty. Make sure to assign HandList with valid cardData in the inspector.");
        }
    }

    // Display an individual card
    private void DisplayCard(CardData card)
    {
        // Check if UI elements are assigned
        if (nameText != null && castLevelText != null && descriptionText != null &&
            costText != null && artworkImage != null && cardImage != null)
        {
            
            nameText.text = card.name;
            castLevelText.text = card.castLevel.ToString();
            descriptionText.text = card.description;
            costText.text = card.cost.ToString();

            artworkImage.sprite = card.artwork;
            cardImage.sprite = card.cardType;
        }
        else
        {
            Debug.LogWarning("One or more UI elements are null. Make sure to assign all UI elements in the inspector.");
        }
    }
}
