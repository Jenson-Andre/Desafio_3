using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lex : Heroes
{
    public Lex(){
        Name = "Lex";
        Title = "Young Blade";
        WeaponColor = 3; //green
        WeaponType = 1; //axe
        MoveType = 2; //cavalry
        Level = 40;
        Merges = 10;
        XP = 0;
        HP = 50;
        Atk = 55;
        Spd = 30;
        Def = 48;
        Res = 19;
        SP = 243;
        Merit = 3546;
        EquipWeapon = "Goddess Axe";
        EquipAssist = "Rally Up Def+";
        EquipSpecial = "Bonfire";
        EquipA = "Distant Counter";
        EquipB = "Vantage 3";
        EquipC = "Def Smoke 3";
        EquipS = "Atk Def Solo 3";
    }

    //public string json = JsonUtility.ToJson(new Lex());
}
