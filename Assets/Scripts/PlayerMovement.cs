using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed;

    private Rigidbody rb;
    private Vector3 input;
    public float fallHeight;
    public AudioSource audioSource;
    public AudioClip gameOverSound;
    public GameManager gm;
    void Awake()
    {
        
        rb = GetComponent<Rigidbody>();
        
    }

    IEnumerator Start()
    {
        // Wait until GameConfig is initialized
        while (GameConfig.I == null || !GameConfig.I.IsLoaded)
            yield return null;

        moveSpeed = GameConfig.I.data.player_data.speed;
        Debug.Log("Player speed loaded: " + moveSpeed);
    }

    void Update()
    {
        float h = Input.GetAxisRaw("Horizontal"); 
        float v = Input.GetAxisRaw("Vertical");

        input = new Vector3(h, 0f, v).normalized;

        if (transform.position.y < 0f)
        {
            if (audioSource != null && gameOverSound != null)
                audioSource.PlayOneShot(gameOverSound);
        }

        if (transform.position.y < fallHeight)
        {
            gm.NextScene();
        }
    }

    void FixedUpdate()
    {

        Vector3 velocity = input * moveSpeed;
        Vector3 move = rb.position + velocity * Time.fixedDeltaTime;

        rb.MovePosition(move);
    }
}
