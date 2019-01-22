using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetTriger : MonoBehaviour
{
    public GameObject Ship;

    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Island"))
        {
            Ship.GetComponent<ShipNavMController>().Targ_Trig = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Island"))
        {
            Ship.GetComponent<ShipNavMController>().Targ_Trig = false;
        }
    }

}
