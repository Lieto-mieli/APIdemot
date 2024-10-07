using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class DataManager : MonoBehaviour 
{ 
    public Player player; 
    private void Update() 
    { 
        if (Input.GetKeyDown(KeyCode.F)) 
        { 
            GetData(); 
        } 
    }
    public void GetData()
    {
        print("Haku");
        string uri = "https://localhost:7141/quest";
        Quest quest = new Quest();
        StartCoroutine(quest.LoadDataFromDatabase(uri, player));
    }
}