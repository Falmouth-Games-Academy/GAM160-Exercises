using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[Serializable]
public class Character
{
    public string Name;
    public int Age;
    public int Health;
    public int Score;
}

public class CharacterManager : MonoBehaviour {

    //The character list
    public List<Character> Characters=new List<Character>();

    //The UI Objects
    public Canvas UICanvas;
    //This is hidden but is a convient way of spawning text dynamically
    public Text UITextTemplate;

	// Use this for initialization
	void Start () {
        //This is around the size of the Canvas
        float startYPosition = 730f;
        //iterate and position the characters on the screen
		foreach(Character c in Characters)
        {
            //Create a UI Text object from the template above
            Text characterText=Instantiate<Text>(UITextTemplate);
            //Display some text from the current characyer
            characterText.text=c.Name+" "+c.Age.ToString()+" "+c.Health.ToString()+" "+c.Score.ToString();
            //Set it as active
            characterText.gameObject.SetActive(true);
            //Set the parent of the current text to the canvas
            characterText.transform.SetParent(UICanvas.transform);
            //Position the element
            characterText.rectTransform.position = new Vector3(100, startYPosition, 0.0f);
            //Increment the position
            startYPosition -= 30.0f;
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
