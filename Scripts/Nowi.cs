using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nowi : Heroes
{
    public Nowi(){
        Name = "Nowi";
        Title = "Eternal Youth";
        WeaponColor = 2; //blue
        WeaponType = 5; //dragon
        MoveType = 1; //infantry
        Level = 40;
        Merges = 10;
        XP = 0;
        HP = 55;
        Atk = 55;
        Spd = 37;
        Def = 37;
        Res = 34;
        SP = 9753;
        Merit = 6881;
        EquipWeapon = "Purifying Breath";
        EquipAssist = "Rally Spd Res+";
        EquipSpecial = "Aether";
        EquipA = "Swift Stance 3";
        EquipB = "Quick Riposte 3";
        EquipC = "Joint Drive Spd";
        EquipS = "Steady Breath";
    }

    public string json = JsonUtility.ToJson(new Nowi());
}
