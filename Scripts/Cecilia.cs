using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cecilia : Heroes
{
    public Cecilia(){
        Name = "Cecilia";
        Title = "Festive Instructor";
        WeaponColor = 4; //colorless
        WeaponType = 4; //Dagger
        MoveType = 3; //Armored
        Level = 40;
        Merges = 10;
        XP = 0;
        HP = 51;
        Atk = 55;
        Spd = 30;
        Def = 40;
        Res = 44;
        SP = 2458;
        Merit = 8563;
        EquipWeapon = "Goodie Boot+";
        EquipAssist = "Pivot";
        EquipSpecial = "Iceberg";
        EquipA = "Close Foil";
        EquipB = "Vengeful Fighter 3";
        EquipC = "Armor March 3";
        EquipS = "Atk Def Form 3";
    }

    //public string json = JsonUtility.ToJson(new Cecilia());
}
