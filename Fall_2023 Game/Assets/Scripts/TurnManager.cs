using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class TurnManager : MonoBehaviour
{
    public UnityEvent turnEndEvent;

    public void EndTurn()
    {
        Debug.Log("End Turn");
        turnEndEvent.Invoke();
        
    }
}
