using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;

public class DiceThrower : MonoBehaviour
{
    public Dice diceToThrow;
    public int amountOfDice = 2;
    public float throwForce = 5f;
    public float rollForce = 10f;

    public IntData castRoll;

    private List<GameObject> _spawnedDice = new List<GameObject>();

    private async void Start()
    {
        if (castRoll == null)
        {
            Debug.LogError("IntData ScriptableObject is not assigned!");
            return;
        }

        // Subscribe to the event only once
        Dice.OnDiceResult += OnDiceResultHandler;

    }

    private async Task StartRollDice()
    {
        await RollDice();
    }

    public async Task RollDice()
    {
        if (diceToThrow == null || castRoll == null) return;

        foreach (var die in _spawnedDice)
        {
            Destroy(die);
        }

        for (int i = 0; i < amountOfDice; i++)
        {
            castRoll.diceRoll = 0;
            Dice dice = Instantiate(diceToThrow, transform.position, transform.rotation);
            _spawnedDice.Add(dice.gameObject);

            // Roll the dice
            dice.RollDice(throwForce, rollForce, i);
            await Task.Yield();
        }
    }

    private void OnDiceResultHandler(int diceIndex, int result, int sum)
    {
        castRoll.diceRoll += sum; // Update the result in the ScriptableObject
        Debug.Log("Total Dice Result is: " + castRoll.diceRoll);
    }

    private void OnDestroy()
    {
        Dice.OnDiceResult -= OnDiceResultHandler; // Unsubscribe from the event
    }
}