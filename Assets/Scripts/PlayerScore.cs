using UnityEngine;

public class PlayerScore : MonoBehaviour
{
    [Header("Tile")]
    private Tile currentTile;

    void OnCollisionEnter(Collision collision)
    {
        Tile tile = collision.collider.GetComponent<Tile>();
        if (tile == null) return;

        if (tile != currentTile)
        {
            currentTile = tile;
            ScoreManager.sc.AddPoint(1);
        }
    }
}
