using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class PlayerController : MonoBehaviour {

    // Use this for initialization
    public List<int> Res = new List<int> {0,0,0,0,0,0};
    public List<string> NameRes = new List<string> { "wood", "stone", "iron", "gold", "board", "steel" };
  
    public List<Text> ScoreText;
   
    public List<GameObject> Players_Island;

  

    //public Recours recours;
    void Start () {
		
	}
	// Update is called once per frame
	void Update () {
        ShowRecours();     
       
    }
   
    public void ShowRecours()
    {
        
        for (int i = 0; i < Res.Count; i++)
        {
            ScoreText[i].text = Res[i].ToString();
        }
      

    }
}
