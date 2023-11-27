using UnityEngine;

public class cube : MonoBehaviour
{
    [SerializeField] private AudioSource audio1;
    [SerializeField] private AudioSource audio2;
    [SerializeField] private GameObject CubeCollection_Effect1;
    [SerializeField] private GameObject CubeCollection_Effect2;
    [SerializeField] private variables script;
    [SerializeField] private bool SuperCube = false;

    private void Update()
    {
        transform.Rotate(0f, 200f * Time.deltaTime, 0f, Space.Self);
    }

    private void OnTriggerEnter()
    {
        if (SuperCube == false)
        {
            audio1.Play();
            Instantiate(CubeCollection_Effect1, transform.position, Quaternion.identity);
            script.ScoreUpdate1();
        }
        else
        {
            audio2.Play();
            Instantiate(CubeCollection_Effect2, transform.position, Quaternion.identity);
            script.ScoreUpdate10();
        }

        gameObject.active = false;
    }
}
