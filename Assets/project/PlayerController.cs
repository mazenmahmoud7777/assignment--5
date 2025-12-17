using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 10f;   // Movement speed

    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.freezeRotation = false;
    }

    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxisRaw("Horizontal");
        float moveVertical = Input.GetAxisRaw("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical).normalized;

        rb.linearVelocity = movement * speed + new Vector3(0, rb.linearVelocity.y, 0);
    }
}

