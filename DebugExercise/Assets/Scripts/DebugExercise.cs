using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[Serializable]
public class Character
{
    public string Name;
    public int Age;
    public int Health;
    public int Score;
}

public class DebugExercise : MonoBehaviour {

	// Use this for initialization
	void Start () {

        Character character = new Character();
        character.Name = "Brian";
        character.Age = 20;
        character.Health = 100;
        character.Score = 10;

        //Q1 What is the character score after the call to AddScore?
        AddScore(character.Score, 10);

        //Q2 What is the character score after the call to AddScoreRef?
        AddScoreRef(ref character.Score, 20);

	}

    void AddScore(int score,int value)
    {
        score += value;
    }

    void AddScoreRef(ref int score, int value)
    {
        score += value;
    }
}
