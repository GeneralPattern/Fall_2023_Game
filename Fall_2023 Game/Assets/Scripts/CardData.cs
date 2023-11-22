using UnityEngine;

[CreateAssetMenu(fileName = "New Card")]
public class CardData : ScriptableObject
{
    public new string name;
    public string description;
    public int castLevel;
    
    public Sprite artwork;
    public Sprite cardType;

    public int cardID;
    public int cost;
    public int damage;
    public int health;
    public int spellSlots;
    public int healingNo;


}
