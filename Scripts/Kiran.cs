using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kiran : Players
{
    public Kiran(){
        _Nick = "Kiran";
        _PlayerCode = "1552568556";
        _HeroesInBarracks = new string[] {"Soleil", "Altena", "Lex", "Cecilia"}; 
    }

    string json = JsonUtility.ToJson(Kiran);
}
