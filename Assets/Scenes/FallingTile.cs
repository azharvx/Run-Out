using UnityEngine;

public class FallingTile : MonoBehaviour
{
    public float fallDelay = 1.5f;

    private Rigidbody rb;
    private bool touched = false;
    private float timer = 0f;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
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

    

