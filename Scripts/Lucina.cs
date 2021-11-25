using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lucina : Heroes
{
     public Lucina(){
        Name = "Lucina";
        Title = "Glorious Archer";
        WeaponColor = 2; //blue
        WeaponType = 3; //bow
        MoveType = 1; //infantry
        Level = 40;
        Merges = 0;
        XP = 0;
        HP = 36;
        Atk = 48;
        Spd = 38;
        Def = 25;
        Res = 20;
        SP = 2455;
        Merit = 8741;
        EquipWeapon = "Thögn";
        EquipAssist = "Future Vision";
        EquipSpecial = "Astra";
        EquipA = "Sorcery Blade 3";
        EquipB = "Wings of Mercy 3";
        EquipC = "Distant Guard 3";
        EquipS = "Atk Spd Bond 3";
    }

    string json = JsonUtility.ToJson(Lucina);
}
