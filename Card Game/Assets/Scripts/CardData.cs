using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum CardType
{
    PHYSICAL,
    MAGICAL,
    FLEXIBLE,
    ASSAULT
}

[CreateAssetMenu(fileName = "NewCard")]
public class CardData : ScriptableObject {

    public int id;
    public new string name;
    public int power;
    public int magicDefense;
    public int physicalDefense;
    public bool[] directions;
    public CardType cardType;
    public Sprite image;
}
