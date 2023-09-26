using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardDatabase : MonoBehaviour
{
    public static List<Card> cardList = new List<Card>();

    void Awake()
    {
        cardList.Add(new Card(0, "None", 0, 0, "none"));
        cardList.Add(new Card(1, "Cory The Defiler", 2, 1, "He quicc he dirty"));
        cardList.Add(new Card(2, "Joe Biden", 1, 0, "Sleepy"));
    }
}
