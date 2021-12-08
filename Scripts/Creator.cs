using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEditor;
using System;
using UnityEngine.UI;

public class Creator : MonoBehaviour
{
    public Button yourButton;
    string saveFile;

    public Altena Altena;

    public GCF GCF;

    public Soleil Soleil;

     //GameData gameData = new GameData();
    private void Start() {
        //string fullPath = Application.dataPath + "/Saves";
        Button btn = yourButton.GetComponent<Button>();
		btn.onClick.AddListener(Criar);
    }

    public void Criar(){
        //Altena.Create();
        string str = JsonUtility.ToJson(new Soleil());
        File.WriteAllText(Application.dataPath + "/Saves/Soleil.json" , str);
        Debug.Log("Criou");
    }
}
