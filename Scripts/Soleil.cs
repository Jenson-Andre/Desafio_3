using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Soleil : Heroes
{
    public Soleil(){
        Name = "Soleil";
        Title = "Adorable Adorer";
        WeaponColor = 1; //red
        WeaponType = 1; //sword
        MoveType = 1; //infantry
        Level = 40;
        Merges = 10;
        XP = 0;
        HP = 53;
        Atk = 67;
        Spd = 48;
        Def = 38;
        Res = 34;
        SP = 6628;
        Merit = 7000;
        EquipWeapon = "Soleil's Shine";
        EquipAssist = "Reposition";
        EquipSpecial = "Galeforce";
        EquipA = "Atk/Spd Solo 4";
        EquipB = "Null Follow-Up 3";
        EquipC = "Threat. Atk Def 3";
        EquipS = "Atk/Spd Solo 3";
    }
    
    public string json = JsonUtility.ToJson(new Soleil());
}
