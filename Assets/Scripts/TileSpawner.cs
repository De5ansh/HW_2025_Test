using UnityEngine;

public class TileSpawner : MonoBehaviour
{
    [Header("Tile Setup")]
    public GameObject tilePrefab;
    public Transform currentTile;       // the currently active tile
    public float tileSize = 9f;

    [Header("Timing")]
    public float spawnInterval = 3f;

    void Start()
    {
        // currentTile should be assigned in the Inspector to the first tile
        spawnInterval = GameConfig.I.data.pulpit_data.pulpit_spawn_time;
        InvokeRepeating(nameof(SpawnNextTile), spawnInterval, spawnInterval);
    }

    void SpawnNextTile()
    {
        Vector3[] offsets = new Vector3[]
        {
            new Vector3(tileSize, 0, 0),    // right
            new Vector3(-tileSize, 0, 0),   // left
            new Vector3(0, 0, tileSize),    // forward
            new Vector3(0, 0, -tileSize)    // back
        };

        // Pick random offset direction
        Vector3 offset = offsets[Random.Range(0, offsets.Length)];

        // New tile position based on currentTile position
        Vector3 spawnPos = currentTile.position + offset;

        // Spawn tile
        GameObject newTile = Instantiate(tilePrefab, spawnPos, Quaternion.identity);

        // Update reference — THIS IS THE KEY POINT
        currentTile = newTile.transform;
    }
}
