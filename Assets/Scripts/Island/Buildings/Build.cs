using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Build : MonoBehaviour
{
    public GameObject Building;
    public Text TextR;
    private void Start()
    {
        Building.SetActive(false);
        TextR.text = "";
        
        for (int i = 0; i < ResPlayer.NameRes.Count; i++)
        {
            TextR.text += ResPlayer.NameRes[i].ToString()+":" + Building.GetComponent<Buildings_type>().Prise[i++].ToString()+" ";
            TextR.text += ResPlayer.NameRes[i].ToString() + ":" + Building.GetComponent<Buildings_type>().Prise[i].ToString() + "\n";
        }
        
    }
    public void Build_Building(Button butt)
    { for (int i = 0; i < ResPlayer.NameBuild.Count; i++)
        {
            int k = 0;
            if (Building.name == ResPlayer.NameBuild[i])
            {
                for (int j = 0; j < ResPlayer.Res.Count; j++)
                {
                    if (Building.GetComponent<Buildings_type>().Prise[j] <= ResPlayer.Res[j])
                    {
                        k++;
                        Debug.Log(k);
                    }
                }
                if (k == 6)
                { 
                    Building.SetActive(true);
                    butt.gameObject.SetActive(false);
                }



            }
        }
    }
}
