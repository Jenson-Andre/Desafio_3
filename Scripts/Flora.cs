using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flora : Heroes
{
    public Flora(){
        Name = "Flora";
        Title = "Cold as Ice";
        WeaponColor = 1; //red
        WeaponType = 4; //dagger
        MoveType = 1; //infantry
        Level = 40;
        Merges = 2;
        XP = 0;
        HP = 39;
        Atk = 52;
        Spd = 24;
        Def = 18;
        Res = 39;
        SP = 5852;
        Merit = 5482;
        EquipWeapon = "Hoarfrost Knife";
        EquipAssist = "Rally Def Res+";
        EquipSpecial = "Iceberg";
        EquipA = "Sturdy Impact";
        EquipB = "Lull Atk Def 3";
        EquipC = "Def Ploy 3";
        EquipS = "Mirror Strike 2";
    }

    public string json = JsonUtility.ToJson(new Flora());
}
