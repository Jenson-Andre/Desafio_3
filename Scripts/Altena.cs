﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Altena : Heroes
{
    public Altena(){
        Name = "Altena";
        Title = "Luminous Rider";
        WeaponColor = 2; //blue
        WeaponType = 1; //lance
        MoveType = 4; //flyer
        Level = 40;
        Merges = 10;
        XP = 0;
        HP = 51;
        Atk = 54;
        Spd = 31;
        Def = 62;
        Res = 36;
        SP = 9999;
        Merit = 7000;
        EquipWeapon = "Earthly Gáe Bolg";
        EquipAssist = "Rally Atk Spd+";
        EquipSpecial = "Bonfire";
        EquipA = "Fort. Def Res 3";
        EquipB = "Quick Riposte 3";
        EquipC = "Hone Atk 4";
        EquipS = "Fort. Def Res 2";
    }
    string json = JsonUtility.ToJson(Altena);
}