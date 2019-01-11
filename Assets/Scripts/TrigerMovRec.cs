using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrigerMovRec : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            other.gameObject.GetComponent<ShipNavMController>().RecourseMoveToShip();
            Debug.Log("Тригер 1 спрацював ");
        }

    }
}
