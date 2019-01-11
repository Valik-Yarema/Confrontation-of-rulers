using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RecoursMove : MonoBehaviour
{
    // Start is called before the first frame update
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Ship"))
        {
            other.GetComponent<ShipController>().RecourseMoveToShip();
        }
    }
}
