using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacterStats
{
    public string Name;
    public int Health;
    public int Strength;
    public int Mana;
}

public class DisplayCharacter : MonoBehaviour {

    //UI Text to hold the text
    public Text UIText;

    //The characters stats, this is what we are displaying
    //to the user
    private CharacterStats characterStats;

    // Use this for initialization
    void Start ()
    {
        //Initialise the chacter stats to default values
        characterStats = new CharacterStats();
        characterStats.Name = "Jo";
        characterStats.Health = 80;
        characterStats.Mana = 0;
        characterStats.Strength = 10;

        //Replace this with a string builder
        UIText.text = "Name: " + characterStats.Name + "\nHealth: " +
            characterStats.Health.ToString() + "\nStrength:  " +
            characterStats.Strength.ToString() + "\nMana: " +
            characterStats.Mana;
    }
}
