using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SomeDude : Players
{
    public SomeDude(){
        _Nick = "SomeDude";
        _PlayerCode = "7325852547";
        _HeroesInBarracks = new List<string> {"Edelgard", "Genny", "Miranda", "Nowi"}; 
    }

    public string json = JsonUtility.ToJson(new SomeDude());
}
