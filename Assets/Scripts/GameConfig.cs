using UnityEngine;
using System.IO;

[System.Serializable]
public class RootData
{
    public PlayerData player_data;
    public PulpitData pulpit_data;
}

[System.Serializable]
public class PlayerData
{
    public float speed;
}

[System.Serializable]
public class PulpitData
{
    public float min_pulpit_destroy_time;
    public float max_pulpit_destroy_time;
    public float pulpit_spawn_time;
}

public class GameConfig : MonoBehaviour
{
    public static GameConfig I;  
    public RootData data;          

    [Header("JSON File Name in StreamingAssets")]
    public string jsonFileName = "doofus_diary.json";

    private void Awake()
    {
        if (I == null)
        {
            I = this;
            DontDestroyOnLoad(gameObject);
            LoadJSON(); 
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void LoadJSON()
    {
        string path = Path.Combine(Application.streamingAssetsPath, jsonFileName);

        if (!File.Exists(path))
        {
            Debug.LogError("GameConfig: JSON file not found at " + path);
            return;
        }

        string json = File.ReadAllText(path);
        data = JsonUtility.FromJson<RootData>(json);

        if (data == null)
        {
            Debug.LogError("GameConfig: Failed to parse JSON");
        }
        else
        {
            Debug.Log("GameConfig: JSON loaded! Player speed = " + data.player_data.speed);
        }
    }

    public bool IsLoaded => data != null;
}
