using UnityEngine;
using System.Collections;
public class TileSpawner : MonoBehaviour
{
    [Header("Tile Setup")]
    public GameObject tilePrefab;
    public Transform currentTile;
    public float tileSize = 9f;

    [Header("Timing")]
    public float spawnInterval = 3f;

    [Header("Audio")]
    public AudioSource audioSource;
    public AudioClip spawnSound;

    void Start()
    {
        spawnInterval = GameConfig.I.data.pulpit_data.pulpit_spawn_time;
        InvokeRepeating(nameof(SpawnNextTile), spawnInterval, spawnInterval);
    }

    void SpawnNextTile()
    {
        Vector3[] offsets = new Vector3[]
        {
            new Vector3(tileSize, 0, 0),    
            new Vector3(-tileSize, 0, 0),   
            new Vector3(0, 0, tileSize),    
            new Vector3(0, 0, -tileSize)    
        };

        Vector3 offset = offsets[Random.Range(0, offsets.Length)];
        Vector3 spawnPos = currentTile.position + offset;
        GameObject newTile = Instantiate(tilePrefab, spawnPos, Quaternion.identity);
        currentTile = newTile.transform;

        if (audioSource != null && spawnSound != null)
            audioSource.PlayOneShot(spawnSound);
    }
}
