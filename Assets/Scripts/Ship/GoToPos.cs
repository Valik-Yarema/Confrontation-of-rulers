using UnityEngine;
using System.Collections;

public class GoToPos : MonoBehaviour
{
   
   private Vector3 position1;
   private bool go;
    private void Start()
    {
        position1= GetComponent<ShipNavMController>()._Target.GetComponent<Transform>().position;
    }
    void Update()
    {
        if ((Input.GetMouseButtonDown(0))) { go = true; }
        if (go) 
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit, Mathf.Infinity))
            {
                position1 = hit.point;
            }
            GetComponent<ShipNavMController>()._Target.GetComponent<Transform>().position = position1;
          //  GetComponent<ShipNavMController>()._StartShip = true;

           go = false;
        }
      
    }
}