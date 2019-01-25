using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HomeOn : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Menu_Home;

    public void Menu_ON()
    {
        Menu_Home.SetActive(true);
    }
}
