using UnityEngine;

public class ForceEmitter : MonoBehaviour
{
    [SerializeField] private Rigidbody rb;
    [SerializeField] private float x;
    [SerializeField] private float y;
    [SerializeField] private float z;

    void OnTriggerStay()
    {
        rb.AddForce(x, y, z, ForceMode.Impulse);
        //rb.drag = 1;
    }
}
