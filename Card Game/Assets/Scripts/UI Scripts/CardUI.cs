using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[ExecuteInEditMode]
public class CardUI : MonoBehaviour {
    #region CARD DATA
    public CardData data;

    public Text powerStatText;
    public Text cardTypeText;
    public Text physicalStatText;
    public Text magicalStatText;

    public Image cardImage;

    public GameObject[] arrows = new GameObject[8];
    #endregion

    #region
    public int teamID;
    public Image cardBackground;
    public Image cardFrame;
    #endregion
    // Use this for initialization
    void Start () {
        powerStatText.text = ConvertToHex(data.power);
        physicalStatText.text = ConvertToHex(data.physicalDefense);
        magicalStatText.text = ConvertToHex(data.magicDefense);
        switch (data.cardType)
        {
            case CardType.ASSAULT:
                cardTypeText.text = "A";
                break;
            case CardType.FLEXIBLE:
                cardTypeText.text = "X";
                break;
            case CardType.PHYSICAL:
                cardTypeText.text = "P";
                break;
            case CardType.MAGICAL:
                cardTypeText.text = "M";
                break;
        }
        for(int i = 0; i < 8; i++)
        {
            arrows[i].SetActive(data.directions[i]);
        }
        cardImage.sprite = data.image;

        if (teamID == 0)
        {
            cardBackground.color = new Color(.51f, .84f, 1);
            cardFrame.color = new Color(.51f, .51f, 1);
        }
        else
        {
            cardBackground.color = new Color(.98f, .61f, .4f);
            cardFrame.color = new Color(.98f, .4f, .4f);
        }
	}
	
	// Update is called once per frame
	void Update () {
        powerStatText.text = ConvertToHex(data.power);
        physicalStatText.text = ConvertToHex(data.physicalDefense);
        magicalStatText.text = ConvertToHex(data.magicDefense);
        switch (data.cardType)
        {
            case CardType.ASSAULT:
                cardTypeText.text = "A";
                break;
            case CardType.FLEXIBLE:
                cardTypeText.text = "X";
                break;
            case CardType.PHYSICAL:
                cardTypeText.text = "P";
                break;
            case CardType.MAGICAL:
                cardTypeText.text = "M";
                break;
        }
        for (int i = 0; i < 8; i++)
        {
            arrows[i].SetActive(data.directions[i]);
        }
        cardImage.sprite = data.image;

        if (teamID == 0)
        {
            cardBackground.color = new Color(.51f, .84f, 1);
            cardFrame.color = new Color(.51f, .51f, 1);
        }
        else
        {
            cardBackground.color = new Color(.98f, .68f, .4f);
            cardFrame.color = new Color(.98f, .4f, .4f);
        }
    }

    string ConvertToHex(int value)
    {
        if (value <= 9) return value.ToString();
        string valueString = "";
        switch (value)
        {
            case 10:
                valueString = "A";
                break;
            case 11:
                valueString = "B";
                break;
            case 12:
                valueString = "C";
                break;
            case 13:
                valueString = "D";
                break;
            case 14:
                valueString = "E";
                break;
            case 15:
                valueString = "F";
                break;
        }
        return valueString;
    }
}
