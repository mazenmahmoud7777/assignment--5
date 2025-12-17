using UnityEngine;
using TMPro;

public class playercont : MonoBehaviour
{
    public float speed = 10f;   // Movement speed

    private Rigidbody rb;

    public TMP_Text scoreText;

    private int scoreCounter;


    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.freezeRotation = false;
        scoreCounter = 0;
        scoreText.text = "score: " + scoreCounter;


    }

    void FixedUpdate()
    {
        // Get input
        float moveHorizontal = Input.GetAxisRaw("Horizontal");
        float moveVertical = Input.GetAxisRaw("Vertical");

        // Create a normalized direction vector
        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical).normalized;

        // Apply movement
        rb.linearVelocity = new Vector3(movement.x * speed, rb.linearVelocity.y, movement.z * speed);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("PickUp"))
        {
            other.gameObject.SetActive(false);

            setscore();
            


        }
    }

    void setscore()
    {
        scoreCounter += 1;

        scoreText.text = "score: " + scoreCounter;
    }
}
