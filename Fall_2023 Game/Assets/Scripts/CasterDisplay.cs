using System;
using UnityEngine;
using UnityEngine.UI;

public class CasterDisplay : MonoBehaviour
{
    public Text healthDisplay;
    public Text castLevelDisplay;
    public CardData caster;
    
    // Start is called before the first frame update
    void Start()
    {
        castLevelDisplay.text = "+" + caster.castLevel.ToString();
    }

    private void Update()
    {
        healthDisplay.text = caster.health.ToString();
    }
}
