using UnityEngine;

public class Spin : MonoBehaviour
{
    [SerializeField] private float x;
    [SerializeField] private float y;
    [SerializeField] private float z;

    void Update()
    {
        transform.Rotate(x * Time.deltaTime, y * Time.deltaTime, z * Time.deltaTime, Space.Self);
    }
}
