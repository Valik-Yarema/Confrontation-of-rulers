using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class ResPlayer
{  
    public static List<int> Res = new List<int> { 0, 0, 0, 0, 0, 0 };
    public static List<string> NameRes = new List<string> { "wood", "stone", "iron", "gold", "board", "steel" };
    public static List<string> NameBuild = new List<string> { "Emporium ","Port","Sawmill","Forge", "Smeltery", "Headquarters", "Barrack_Bowman", "Barrack_Shieldman", "Barack_Spearman"};
    enum Island
    {
        wood,
        stone,
        iron,
        gold,
        board,
        steel
    }

    public static List<Vector3> Pos_Nature = new List<Vector3>
        {
         { new Vector3(-1.75f, -0.8f, 0.5f) },//wood
         { new Vector3(-0.33f, -0.33f, -1.4f) },//stone
         { new Vector3(-0.33f, -0.33f, -1.4f) },//iron
         { new Vector3(0,-0.5f,0) } //gold
      };

    //public static int[,] Prise = new int[9, 6];
    public static List<int[]> Prise=new List<int[]>
   {
      new int[]{50,20,0,0,0,0},//Emporium
     new int[] {80,50,0,10,0,0},//Port
     new int[] {50,50,50,20,0,0},//Sawmill
     new int[] {50,100,50,30,20,0},//Forge
     new int[] {50,100,50,10,20,5},//Smeltery
     new int[] {150,150,150,100,100,100},//Headquarters
     new int[] {100,100,50,20,50,10},//Bowman
     new int[] {100,100,50,25,50,20},//Shieldman
     new int[] {100,100,50,30,50,30} //Spearman
   };
}
