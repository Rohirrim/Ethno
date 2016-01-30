﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Language : MonoBehaviour
{
    
    public List<int> words;

    public int salut;
    public int insulte;
    public int oui;
    public int non;

    public int answerSalut;
    public int answerInsulte;
    public int answerOui;
    public int answerNon; 

	void Start ()
    {
        List<int> tmp = new List<int>(words);

        salut = tmp[Random.Range(0, tmp.Count)];
        tmp.Remove(salut);
        insulte = tmp[Random.Range(0, tmp.Count)];
        tmp.Remove(insulte);
        oui = tmp[Random.Range(0, tmp.Count)];
        tmp.Remove(oui);
        non = tmp[Random.Range(0, tmp.Count)];
        tmp.Remove(non);

        tmp = new List<int>(words);

        answerSalut = tmp[Random.Range(0, tmp.Count)];
        tmp.Remove(answerSalut);
        answerInsulte = tmp[Random.Range(0, tmp.Count)];
        tmp.Remove(answerInsulte);
        answerOui = tmp[Random.Range(0, tmp.Count)];
        tmp.Remove(answerOui);
        answerNon = tmp[Random.Range(0, tmp.Count)];
        tmp.Remove(answerNon);
	}

    public bool PlayerAnswerMatch(int question, int answer)
    {
        if (question == salut)
            return answerSalut == answer;
        else if (question == insulte)
            return answerInsulte == answer;
        else if (question == oui)
            return answerOui == answer;
        else if (question == non)
            return answerNon == answer;

        return false;
    }
}
