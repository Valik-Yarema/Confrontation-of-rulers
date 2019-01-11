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
    public Text ScoreText;
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
       
          ScoreText.text = "wood : "+wood.ToString() +"\t stone : "+stone.ToString()+"\t iron : "+iron.ToString()+"\t gold : "+gold.ToString();

    }
}
