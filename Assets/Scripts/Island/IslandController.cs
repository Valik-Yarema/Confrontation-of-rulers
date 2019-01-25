using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IslandController : MonoBehaviour {
    private GameObject ParentControl;
    private float[] mas;
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
        mas = GetComponentInParent<Island_Controller>().resRender;
	}
	
	// Update is called once per frame
	void Update () {
        tw += Time.deltaTime*mas[0];
        ts += Time.deltaTime * mas[1];
        ti += Time.deltaTime * mas[2];
        tg += Time.deltaTime * mas[3];
      RecourceGeneration(ref wood,ref tw);
      RecourceGeneration(ref stone, ref ts);
      RecourceGeneration(ref iron,ref ti);     
      RecourceGeneration(ref gold, ref tg);

    }


}
