using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class ResPlayer 
{
    private static List<int> res = new List<int> { 0, 0, 0, 0, 0, 0 };

    public static List<int> Res { get => res; set => res = value; }

    //static public List<string> NameRes = new List<string> { "wood", "stone", "iron", "gold", "board", "steel" };

    enum Island
    {
        wood,
        stone,
        iron,
        gold,
        board,
        steel
    }
}
