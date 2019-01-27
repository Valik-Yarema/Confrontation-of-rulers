using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using UnityEditor;

public class Island_Controller : MonoBehaviour
{
    public GameObject Buildings;
    public List<GameObject> Islands;
    public int number_of_players = 1;

    public List<GameObject> IslandPref;
    public bool randomNatureIsland = true;


    private new List<string> name = new List<string> { "wood", "stone", "iron", "gold"};
  
    private float[] resRender = new float[4] { 2.0f,1.5f,1.0f,0.5f}; //повинне дорівнювати кіькості елементів name[]  - скрити 
    private float tem_Resrender=0;


    
    private void Awake()
 {
        

        for (int i = 0, j=0; i < number_of_players * 4;i++,j++ )
        {
      
            Islands[i].gameObject.GetComponentInChildren<Island_Type>().Island_Type_res.NameR = name[j];
            Islands[i].gameObject.GetComponentInChildren<Island_Type>().Island_Type_res.T_Mn = resRender[j];
            if (j == 3) { j = 0; }

          /* i++;
            Islands[i].gameObject.GetComponentInChildren<Island_Type>().Island_Type_res.NameR = name[1];
            Islands[i++].gameObject.GetComponentInChildren<Island_Type>().Island_Type_res.T_Mn = resRender[1];

        
            Islands[i].gameObject.GetComponentInChildren<Island_Type>().Island_Type_res.NameR = name[2];
            Islands[i++].gameObject.GetComponentInChildren<Island_Type>().Island_Type_res.T_Mn = resRender[2];

     
            Islands[i].gameObject.GetComponentInChildren<Island_Type>().Island_Type_res.NameR = name[3];
            Islands[i].gameObject.GetComponentInChildren<Island_Type>().Island_Type_res.T_Mn = resRender[3];
            */
        }
        for (int i = ((number_of_players*4)); i < Islands.Count; i++)
        {
            int ren = Random.Range((int)0, (int)4);
            if (!(Islands[i].tag == "Home"))
            {               
                //Islands[i] = (GameObject)PrefabUtility.InstantiatePrefab(IslandPref[ren]);
            }     
            Islands[i].gameObject.GetComponentInChildren<Island_Type>().Island_Type_res.NameR = name[ren];
            Islands[i].gameObject.GetComponentInChildren<Island_Type>().Island_Type_res.T_Mn = resRender[ren];

          
        }
    }
    
}
