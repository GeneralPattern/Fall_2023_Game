using UnityEngine;

[CreateAssetMenu(fileName = "New Card")]
public class CardData : ScriptableObject
{
    public new string name;
    public string description;
    public string castLevel;
    
    public Sprite artwork;
    public Sprite cardType;
    
    public int cost;
    public int damage;
    public int health;
    public int spellSlots;
    

    
    public void Print()
    {
        Debug.Log(name + " " + description + ", The card costs: " + cost);
    }
}
