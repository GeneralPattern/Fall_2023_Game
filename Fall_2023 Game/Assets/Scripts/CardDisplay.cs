using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;


public class CardDisplay : MonoBehaviour
{
    public CardData card;

    public Text nameText;
    public Text descriptionText;
    public Image artworkImage;

    public Text costText;
    
    void Start()
    {
        nameText.text = card.name;
    }
}
