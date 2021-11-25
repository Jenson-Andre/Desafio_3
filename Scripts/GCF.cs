using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GCF : Players{
    public GCF(){
        _Nick = "GCF";
        _PlayerCode = "9547656684";
        _HeroesInBarracks = new string[] {"Flora", "Lucina", "Reyson", "Leonie"}; 
    }

    string json = JsonUtility.ToJson(GCF);
}
