using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Edelgard : Heroes
{
     public Edelgard(){
        Name = "Edelgard";
        Title = "Hegemon Husk";
        WeaponColor = 4; //colorless
        WeaponType = 6; //beast
        MoveType = 3; //Armored
        Level = 40;
        Merges = 0;
        XP = 0;
        HP = 45;
        Atk = 56;
        Spd = 11;
        Def = 44;
        Res = 43;
        SP = 5165;
        Merit = 3401;
        EquipWeapon = "Twin-Crest Power";
        EquipAssist = "Reposition";
        EquipSpecial = "Bonfire";
        EquipA = "Atk Def Ideal 4";
        EquipB = "Armored Wall";
        EquipC = "Armor Stride 3";
        EquipS = "Mystic Boost 3";
    }

    public string json = JsonUtility.ToJson(new Edelgard());
}
