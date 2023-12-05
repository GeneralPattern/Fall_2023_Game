using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class Store : MonoBehaviour
{
    public CardList deckList;
    public CardData storeItem01;
    public CardData storeItem02;
    public CardData storeItem03;
    public CardData storeItem04;
    public CardData storeItem05;
    public CardData storeItem06;
    public IntData gold;

    public Text goldDisplay;

    public void PurchaseCard01()
    {
        if (gold.value >= 50)
        {
            IList<CardData> cardList = deckList.cardData;
            
            cardList.Add(storeItem01);
        }
        else
        {
            Debug.Log("Not Enough Dough");
        }
    }
    
    public void PurchaseCard02()
    {
        if (gold.value >= 50)
        {
            IList<CardData> cardList = deckList.cardData;
            
            cardList.Add(storeItem02);
        }
        else
        {
            Debug.Log("Not Enough Dough");
        }
    }
    public void PurchaseCard03()
    {
        if (gold.value >= 50)
        {
            IList<CardData> cardList = deckList.cardData;
            
            cardList.Add(storeItem03);
        }
        else
        {
            Debug.Log("Not Enough Dough");
        }
    }
    
    public void PurchaseCard04()
    {
        if (gold.value >= 50)
        {
            IList<CardData> cardList = deckList.cardData;
            
            cardList.Add(storeItem04);
        }
        else
        {
            Debug.Log("Not Enough Dough");
        }
    }
    
    public void PurchaseCard05()
    {
        if (gold.value >= 50)
        {
            IList<CardData> cardList = deckList.cardData;
            
            cardList.Add(storeItem05);
        }
        else
        {
            Debug.Log("Not Enough Dough");
        }
    }
    
    public void PurchaseCard06()
    {
        if (gold.value >= 50)
        {
            IList<CardData> cardList = deckList.cardData;
            
            cardList.Add(storeItem06);
        }
        else
        {
            Debug.Log("Not Enough Dough");
        }
    }
    
    public void Update()
    {
        goldDisplay.text = "Gold: " + gold.value.ToString();
    }
}
