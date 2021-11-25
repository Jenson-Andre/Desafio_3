using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Leonie : Heroes
{
    public Leonie(){
        Name = "Leonie";
        Title = "Relentless Rays";
        WeaponColor = 4; //colorless
        WeaponType = 3; //bow
        MoveType = 2; //cavalry
        Level = 40;
        Merges = 6;
        XP = 0;
        HP = 45;
        Atk = 46;
        Spd = 42;
        Def = 29;
        Res = 21;
        SP = 9999;
        Merit = 3577;
        EquipWeapon = "Brave Bow+";
        EquipAssist = "Reposition";
        EquipSpecial = "Moonbow";
        EquipA = "Swift Sparrow 3";
        EquipB = "Lull Spd Def 3";
        EquipC = "Savage Blow 3";
        EquipS = "Blade Session";
    }

    string json = JsonUtility.ToJson(Leonie);
}
