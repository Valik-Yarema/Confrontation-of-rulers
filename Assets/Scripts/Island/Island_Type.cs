using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor; 

public class Island_Type : MonoBehaviour
{
   public struct I_Resours
    {
        public string NameR;
        public int res_cap;
        public float T_Mn;//коефіцієнт множення ресурса
        public double time_r;
    }

    public I_Resours Island_Type_res;
    public int resoursInIsland=0;
    public GameObject Nature;
    private new List<string> name = new List<string> { "wood", "stone", "iron", "gold" };

    private int RecourceGeneration(ref int res, ref double tm)
    {
        if (tm >= 1)
        {
            res++;
            tm = 0;
        }
        return res;
    }

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 4; i++)
        {
            if ((Island_Type_res.NameR == name[i]) && (tag != "Home")&&(gameObject.GetComponentInParent<Island_Controller>().randomNatureIsland))
            {
                Nature = Instantiate(gameObject.GetComponentInParent<Island_Controller>().IslandPref[i], transform.position + ResPlayer.Pos_Nature[i], transform.rotation)as GameObject;
            }
        }
      
        Island_Type_res.time_r = 0;
    }

    // Update is called once per frame
    void Update()
    { 
        Island_Type_res.time_r += Time.deltaTime * Island_Type_res.T_Mn;

        RecourceGeneration(ref Island_Type_res.res_cap, ref Island_Type_res.time_r);
        resoursInIsland = Island_Type_res.res_cap;


        if (tag == "Home")
        {
            for (int i = 0; i < ResPlayer.Res.Count; i++)
            {
                if (Island_Type_res.NameR == ResPlayer.NameRes[i])
                {
                    ResPlayer.Res[i] += Island_Type_res.res_cap;
                }
            }
            Island_Type_res.res_cap = 0;
        }
    }
}
