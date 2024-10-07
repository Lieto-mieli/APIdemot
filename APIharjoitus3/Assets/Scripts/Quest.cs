using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using Newtonsoft.Json;
[System.Serializable]
public class Quest 
{ 
    public int Id { get; set; } 
    public string? Name { set; get; } 
    public string? Description { set; get; } 
    public int Reward { set; get; } 
    public Quest() { } 
    public Quest(int id, string name, string description, int reward) 
    { 
        Id = id; 
        Name = name; 
        Description = description; 
        Reward = reward; 
    } 
    public IEnumerator LoadDataFromDatabase(string uri, Player player) 
    { 
        string json;
        using UnityWebRequest request = UnityWebRequest.Get(uri);
        yield return request.SendWebRequest();
        if (request.error != null)
        {
            Debug.LogError($"Nettivirhe: {request.error}");
        }
        else
        {
            json = request.downloadHandler.text;Quest[] 
            quests = JsonConvert.DeserializeObject<Quest[]>(json);
            Debug.Log($"Id:{quests[0].Id}, Name:{quests[0].Name}");
            Debug.Log($"Id:{quests[1].Id}, Name:{quests[1].Name}");
        }
    }
}