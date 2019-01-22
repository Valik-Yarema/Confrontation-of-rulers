using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Panel_Ship : MonoBehaviour
{
    public GameObject M_Panel;
    public GameObject On_Button;
    public void Active_Panel()
    {
        M_Panel.SetActive(true);
        On_Button.SetActive(false);
    }
    public void Des_Active_Panel()
    {
        M_Panel.SetActive(false);
        On_Button.SetActive(true);
    }
}

