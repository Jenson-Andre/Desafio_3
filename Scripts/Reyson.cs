using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reyson : Heroes
{
    public Reyson(){
        Name = "Reyson";
        Title = "White Prince";
        WeaponColor = 3; //green
        WeaponType = 6; //beast
        MoveType = 4; //flyer
        Level = 40;
        Merges = 5;
        XP = 0;
        HP = 39;
        Atk = 55;
        Spd = 46;
        Def = 21;
        Res = 23;
        SP = 3576;
        Merit = 5364;
        EquipWeapon = "Heron Wing";
        EquipAssist = "Sing";
        EquipSpecial = "Glimmer";
        EquipA = "Life and Death 4";
        EquipB = "A/D Near Trace 3";
        EquipC = "Fortify Beasts";
        EquipS = "Chill Spd 3";
    }

    public string json = JsonUtility.ToJson(new Reyson());
}
