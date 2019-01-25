using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Buildings_type : MonoBehaviour
{
    public List<int> Prise;
    public bool Activ = true;//false
 

    void Start()
    {
        gameObject.SetActive(Activ);
    }

    // Update is called once per frame
    void Update()
    {
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
                if (GetComponentInParent<PlayerController>().Res[2] - 4 >= 0)
                {
                    GetComponentInParent<PlayerController>().Res[2] -= 4;
                    GetComponentInParent<PlayerController>().Res[5] += 2;
                }
                    }
        }
        if (gameObject.name == "Forge")
        {

        }
        if (gameObject.name == "Smeltery")
        {

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
}
