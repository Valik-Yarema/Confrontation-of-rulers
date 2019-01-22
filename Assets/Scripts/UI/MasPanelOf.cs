using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MasPanelOf : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Panel;

    public void Off_PAnel()
    {
        Panel.SetActive(false);
    }
}
