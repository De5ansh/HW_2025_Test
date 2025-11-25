using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed;

    private Rigidbody rb;
    private Vector3 input;

    void Awake()
    {
        rb = GetComponent<Rigidbody>();
        moveSpeed = GameConfig.I.data.player_data.speed;
        Debug.Log("PlayerMovement: Speed loaded from JSON = " + moveSpeed);
    }

    void Update()
    {
        float h = Input.GetAxisRaw("Horizontal"); 
        float v = Input.GetAxisRaw("Vertical");

        input = new Vector3(h, 0f, v).normalized;
    }

    void FixedUpdate()
    {

        Vector3 velocity = input * moveSpeed;
        Vector3 move = rb.position + velocity * Time.fixedDeltaTime;

        rb.MovePosition(move);
    }
}
