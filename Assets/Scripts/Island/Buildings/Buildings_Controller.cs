using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Buildings_Controller : MonoBehaviour
{
    public List<GameObject> Buildings;
    //  private List<PriseB> prise_Buildings;
    private int[,] Prise = new int[9, 6]
    {
      {50,20,0,0,0,0},//Emporium
      {80,50,0,10,0,0},//Port
      {50,50,50,20,0,0},//Sawmill
      {50,100,50,30,20,0},//Forge
      {50,100,50,10,20,5},//Smeltery
      {150,150,150,100,100,100},//Headquarters
      {100,100,50,20,50,10},//Bowman
      {100,100,50,25,50,20},//Shieldman
      {100,100,50,30,50,30} //Spearman
    };
    // Start is called before the first frame update
    private void Awake()
    {
        for (int i = 0; i < Buildings.Count; i++)
        {
            for (int j = 0; j < 6; j++)
            {
               Buildings[i].GetComponent<Buildings_type>().Prise.Add(Prise[i, j]);
            }
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
