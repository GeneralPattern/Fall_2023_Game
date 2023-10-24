using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;


public class CardDisplay : MonoBehaviour
{
    public CardData card;

    public Text nameText;
    public Text subNameText;
    public Text descriptionText;
    public Image artworkImage;
    public Image cardImage;

    public Text costText;
    
    void Start()
    {
        nameText.text = card.name;
        subNameText.text = card.subName;
        descriptionText.text = card.description;
        
        artworkImage.sprite = card.artwork;
        cardImage.sprite = card.cardType;
    }
}
