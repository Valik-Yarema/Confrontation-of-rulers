using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Buildings_Controller : MonoBehaviour
{
    public List<GameObject> Buildings;
    //  private List<PriseB> prise_Buildings;
   
    // Start is called before the first frame update
    private void Awake()
    {
        for (int i = 0; i < Buildings.Count; i++)
        {           
                Buildings[i].GetComponent<Buildings_type>().Prise = ResPlayer.Prise[i];                        
        }
    }
   
}
