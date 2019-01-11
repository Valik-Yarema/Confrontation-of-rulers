using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class AfterRenamed : MonoBehaviour
{
    // Start is called before the first frame update
  public List<IslandProfile> _islands;
    void Start()
    {
        _islands = Resources.LoadAll<IslandProfile>("IslandsP/").ToList();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
