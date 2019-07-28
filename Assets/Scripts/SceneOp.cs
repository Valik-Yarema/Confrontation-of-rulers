using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneOp : MonoBehaviour
{
   
 public void ScenOpen(int n)
    {
        Application.LoadLevel(n);
    }
}
