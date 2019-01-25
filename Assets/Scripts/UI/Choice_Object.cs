using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Choice_Object : MonoBehaviour
{
    private GameObject DesSelectObject;

    private bool sel1=false;
    private bool select;
    private void Start()
    {
     
    }
    void Update()
    {
        if ((Input.GetMouseButtonDown(0))) { select = true; }
        if (select)
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit, Mathf.Infinity))
            {
                if (hit.collider.tag == "Ship")
                {
                    hit.collider.gameObject.GetComponent<Object_Select>().This_Object_Select = true;
                }
                if ((hit.collider.tag == "Island")  || (hit.collider.tag == "Home"))
                {
                    try
                    {
                        DesSelectObject = hit.collider.gameObject;

                        hit.collider.gameObject.GetComponent<Object_Select>().This_Object_Select = true;
                        
                        //написати визов менюшки острова
                        Panel_Ship.print(hit.collider.gameObject.GetComponent<Island_Type>().Island_Type_res.NameR + " : " + hit.collider.gameObject.GetComponent<Island_Type>().Island_Type_res.res_cap);
                    }
                    catch
                    {
                        Debug.Log("miss Object");
                    }

                    
                }
            }
          

            select = false;
        }

    }
}
