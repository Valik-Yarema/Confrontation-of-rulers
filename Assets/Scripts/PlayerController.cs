using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class PlayerController : MonoBehaviour {

  
    public List<Text> ScoreText;
   
    public List<GameObject> Players_Island;

 
	void Update () {
        ShowRecours();     
       
    }
   
    public void ShowRecours()
    {
        
        for (int i = 0; i < ResPlayer.Res.Count; i++)
        {
        
            ScoreText[i].text = ResPlayer.Res[i].ToString();
        }
      

    }
}
