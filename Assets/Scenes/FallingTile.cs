using UnityEngine;

public class FallingTile : MonoBehaviour
{
    public float fallDelay = 1.5f;

    private Rigidbody rb;
    private bool touched = false;
    private float timer = 0f;
    private Vector3 startPos;
    private Quaternion startRot;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        startPos = transform.position;
        startRot = transform.rotation;
    }
    void Update()
    {
        if (touched)
        {
            timer += Time.deltaTime;
            if (timer >= fallDelay)
            {
                rb.isKinematic = false;
            }
            if (timer >= fallDelay + 4f)
            {
                rb.linearVelocity = Vector3.zero;
                rb.isKinematic = true;
                transform.position = startPos;
                transform.rotation = startRot;
                touched = false;
                timer = 0f;
            }
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            touched = true;
        }
    }
}

    

