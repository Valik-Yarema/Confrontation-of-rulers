using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
    public int Res_IN_Isl = 0;                 //Стерти!!!
    public int RecourceGeneration(ref int res, ref double tm)
    {
        if (tm >= 1)
        {
            ++res;
            tm = 0;
        }
        return res;
    }

    // Start is called before the first frame update
    void Start()
    {
        Island_Type_res.time_r = 0;
    }

    // Update is called once per frame
    void Update()
    {
        Island_Type_res.time_r += Time.deltaTime * Island_Type_res.T_Mn;
        RecourceGeneration(ref Island_Type_res.res_cap, ref Island_Type_res.time_r);
      //  Debug.Log(Island_Type_res.NameR+" : "+Island_Type_res.res_cap+" : "+Island_Type_res.T_Mn); провірка 
        Res_IN_Isl = Island_Type_res.res_cap;
    }
}
