using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Genny : Heroes
{
    public Genny(){
        Name = "Genny";
        Title = "Endearing Ally";
        WeaponColor = 4; //colorless
        WeaponType = 1; //staff
        MoveType = 1; //infantry
        Level = 40;
        Merges = 3;
        XP = 0;
        HP = 35;
        Atk = 54;
        Spd = 26;
        Def = 22;
        Res = 36;
        SP = 9999;
        Merit = 6435;
        EquipWeapon = "Springtime Staff";
        EquipAssist = "Physic+";
        EquipSpecial = "Heavenly Light";
        EquipA = "Atk Res Ideal 4";
        EquipB = "Wrathful Staff 3";
        EquipC = "Savage Blow 3";
        EquipS = "Savage Blow 3";
    }

    string json = JsonUtility.ToJson(Genny);
}
