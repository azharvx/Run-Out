using UnityEngine;

public class FinishLine : MonoBehaviour
{
    public Transform nextStartPoint;

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            PlayerMovement pm = collision.gameObject.GetComponent<PlayerMovement>();
            pm.spawnPoint = nextStartPoint;
            collision.transform.position = nextStartPoint.position;
        }
    }
}
    
