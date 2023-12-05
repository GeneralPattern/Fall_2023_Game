using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "IntData")]
public class IntData : ScriptableObject
{
    public int goldAmount;
    public int diceRoll;
    public int enemyHealth;
    public int value = 0;


    public void AddToValue(int num)
    {
        value += 20;
    }
}

