using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Miranda : Heroes
{
    public Miranda(){
        Name = "Miranda";
        Title = "Willful Princess";
        WeaponColor = 1; //red
        WeaponType = 2; //tome
        MoveType = 1; //infantry
        Level = 40;
        Merges = 7;
        XP = 0;
        HP = 45;
        Atk = 56;
        Spd = 45;
        Def = 25;
        Res = 41;
        SP = 4705;
        Merit = 5346;
        EquipWeapon = "Luminous Grace+";
        EquipAssist = "Harsh Command+";
        EquipSpecial = "Blazing Wind";
        EquipA = "Mirror Impact";
        EquipB = "Special Spiral 3";
        EquipC = "Spd Res Gap 3";
        EquipS = "Heavy Blade 3";
    }

    //public string json = JsonUtility.ToJson(new Miranda());
}
