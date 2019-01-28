using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Buildings_type : MonoBehaviour
{
    public int[] Prise=new int[6];
    public bool Activ = true;//false
    private double tm=0;

    void Start()
    {
        gameObject.SetActive(Activ);
    }

    // Update is called once per frame
    void Update()
    {
        tm += Time.deltaTime/4;

        if (gameObject.name == "Emporium")
        {

        }
        if (gameObject.name == "Port")
        {

        }
        if (gameObject.name == "Sawmill")
        {
            if (Activ)
            {
                if (tm >= 1)
                {
                    if (ResPlayer.Res[0] - 4 >= 0)
                    {
                        ResPlayer.Res[0] -= 4;
                        ResPlayer.Res[4] += 3;
                    }
                    tm = 0;
                }
            }
        }
        if (gameObject.name == "Forge")
        {
            if (Activ)
            {
                if (tm >= 1)
                {
                    if (ResPlayer.Res[2] - 4 >= 0)
                    {
                        ResPlayer.Res[2] -= 4;
                        ResPlayer.Res[5] += 2;
                    }
                    tm = 0;
                }
            }
        }
        if (gameObject.name == "Smeltery")
        {
            if (Activ)
            {
                if (tm >= 1)
                {
                    if (ResPlayer.Res[2] - 6 >= 0)
                    {
                        ResPlayer.Res[2] -= 2;
                        ResPlayer.Res[5] += 2;
                    }
                    tm = 0;
                }
            }
        }
        if (gameObject.name == "Headquarters")
        {

        }
        if (gameObject.name == "Barrack_Bowman")
        {

        }
        if (gameObject.name == "Barrack_Shieldman")
        {

        }
        if (gameObject.name == "Barack_Spearman")
        {

        }


    }

    private int RecourceGeneration(ref int res, ref double tm)
    {
        if (tm >= 1)
        {
            res++;
            tm = 0;
        }
        return res;
    }
}
