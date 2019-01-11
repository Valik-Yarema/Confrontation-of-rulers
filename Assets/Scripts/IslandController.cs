using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IslandController : MonoBehaviour {
    public int wood;
    public int stone;
    public int iron;
    public int gold;
   
    public double tw=0;
    private double ts = 0;
    private double ti = 0;
    private double tg = 0;

    public int RecourceGeneration(ref int res,  ref double tm)
    {
        if (tm >= 1)
        { 
        ++res;
            tm = 0;
        }
        return res;
    }
    
    public int GetRecours(int res)
    {
        return res;
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        tw += Time.deltaTime*2;
        ts += Time.deltaTime * 0.8*2;
        ti += Time.deltaTime * 0.5*2;
        tg += Time.deltaTime * 0.1*2;
      RecourceGeneration(ref wood,ref tw);
      RecourceGeneration(ref stone, ref ts);
      RecourceGeneration(ref iron,ref ti);     
      RecourceGeneration(ref gold, ref tg);

    }


}
