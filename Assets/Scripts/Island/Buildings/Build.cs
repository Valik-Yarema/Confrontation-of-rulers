using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Build : MonoBehaviour
{
    public GameObject Building;
    // public List<GameObject> Building;
    //  public List<Button> button;
    //  public GUIContent Content;
    private void Start()
    {
        Building.SetActive(false);
        /*for (int i = 0; i < Building.Count; i++)
        {
            Building[0].SetActive(false);
        }*/
    }
    public void Build_Building()
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
                }



            }
        }
    }
}
