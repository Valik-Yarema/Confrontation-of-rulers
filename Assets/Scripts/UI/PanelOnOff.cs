using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelOnOff : MonoBehaviour
{

    public void ActivPanel(GameObject Panel)
    {
        Panel.SetActive(true);
    }

    public void DesActivPanel(GameObject Panel)
    {
        Panel.SetActive(false);
    }


}
