using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using UnityEditor;

public class Island_Controller : MonoBehaviour
{
    public GameObject Buildings;
    public List<GameObject> Islands;
    public int number_of_players=1;

    public List<GameObject> IslandPref;
    public List<Vector3> Pos_Nature;
    private new List<string> name = new List<string> { "wood", "stone", "iron", "gold"};
  
    public float[] resRender = new float[4] { 2.0f,1.5f,1.0f,0.5f}; //повинне дорівнювати кіькості елементів name[]  - скрити 
    public bool randomNatureIsland = true;
    private float tem_Resrender=0;


    
    private void Awake()
 {
        Pos_Nature.Add(new Vector3(-1.75f, -0.8f, 0.5f));//wood
        Pos_Nature.Add(new Vector3(-0.33f, -0.33f, -1.4f));//stone
        Pos_Nature.Add(new Vector3(-0.33f, -0.33f, -1.4f));//iron
        Pos_Nature.Add(new Vector3(0,-0.5f,0));//gold

        for (int i = 0; i < number_of_players * 4;i++ )
        {
      
            Islands[i].gameObject.GetComponentInChildren<Island_Type>().Island_Type_res.NameR = name[0];
            Islands[i++].gameObject.GetComponentInChildren<Island_Type>().Island_Type_res.T_Mn = resRender[0];

          
            Islands[i].gameObject.GetComponentInChildren<Island_Type>().Island_Type_res.NameR = name[1];
            Islands[i++].gameObject.GetComponentInChildren<Island_Type>().Island_Type_res.T_Mn = resRender[1];

        
            Islands[i].gameObject.GetComponentInChildren<Island_Type>().Island_Type_res.NameR = name[2];
            Islands[i++].gameObject.GetComponentInChildren<Island_Type>().Island_Type_res.T_Mn = resRender[2];

     
            Islands[i].gameObject.GetComponentInChildren<Island_Type>().Island_Type_res.NameR = name[3];
            Islands[i].gameObject.GetComponentInChildren<Island_Type>().Island_Type_res.T_Mn = resRender[3];
        }
        for (int i = ((number_of_players*4)); i < Islands.Count; i++)
        // for (int i = 0; i < Islands.Count; i++)
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
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
