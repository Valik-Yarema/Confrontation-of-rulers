using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class Island_Controller : MonoBehaviour
{
    public List<GameObject> Islands;
    public int number_of_players=1;

    private new List<string> name = new List<string> { "wood", "stone", "iron", "gold"};
  
    public float[] resRender = new float[4] { 2.0f,1.5f,1.0f,0.5f}; //повинне дорівнювати кіькості елементів name[]  - скрити 
    private float tem_Resrender=0;


    
    private void Awake()
    {       // розкоментувати коли будуть нормально зроблені острови 
            // по 4 обовязкових острова на гравця/бота і подальша рандомна генерація островів 
        for (int i = 0; i < number_of_players * 4;i++ )
        {
            Islands[i].gameObject.GetComponent<Island_Type>().Island_Type_res.NameR = name[0];
            Islands[i++].gameObject.GetComponent<Island_Type>().Island_Type_res.T_Mn = resRender[0];

            Islands[i].gameObject.GetComponent<Island_Type>().Island_Type_res.NameR = name[1];
            Islands[i++].gameObject.GetComponent<Island_Type>().Island_Type_res.T_Mn = resRender[1];

            Islands[i].gameObject.GetComponent<Island_Type>().Island_Type_res.NameR = name[2];
            Islands[i++].gameObject.GetComponent<Island_Type>().Island_Type_res.T_Mn = resRender[2];

            Islands[i].gameObject.GetComponent<Island_Type>().Island_Type_res.NameR = name[3];
            Islands[i].gameObject.GetComponent<Island_Type>().Island_Type_res.T_Mn = resRender[3];
        }
        for (int i = ((number_of_players*4)); i < Islands.Count; i++)
       // for (int i = 0; i < Islands.Count; i++)
        {
            int ren = Random.Range((int)0, (int)4);
            Islands[i].gameObject.GetComponent<Island_Type>().Island_Type_res.NameR = name[ren];
            Islands[i].gameObject.GetComponent<Island_Type>().Island_Type_res.T_Mn = resRender[ren];

          
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
