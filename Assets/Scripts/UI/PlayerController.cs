using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class PlayerController : MonoBehaviour {

    // Use this for initialization
    public int wood = 0;
    public int stone = 0;
    public int iron = 0;
    public int gold = 0;
    public int board = 0;
    public int steel = 0;
    public List<Text> ScoreText;
    //public Recours recours;
    void Start () {
		
	}
	// Update is called once per frame
	void Update () {
        ShowRecours();     
    }

    public void ShowRecours()
    {
        // ScoreText.gameObject.GetComponent<Text>().text= "wtf ?";

        ScoreText[0].text =  wood.ToString();
        ScoreText[1].text = iron.ToString();
        ScoreText[2].text = stone.ToString();
        ScoreText[3].text = board.ToString();
        ScoreText[4].text = steel.ToString();
        ScoreText[5].text = gold.ToString();

    }
}
