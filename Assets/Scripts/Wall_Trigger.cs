using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wall_Trigger : MonoBehaviour
{
    [SerializeField] private variables script1;
    [SerializeField] private GameObject Green;
    [SerializeField] private MeshRenderer Red;
    [SerializeField] private ParticleSystem Subtract;
    [SerializeField] private Transform SubtractOBJ;
    private int RandomNumber;
    private float time;
    private bool RedActive = false;

    private void Update()
    {
        time += Time.deltaTime;
        if (RandomNumber == 0)
        {
            RedActive = false;
            Green.SetActive(true);
            Red.enabled = false;
        }
        else
        {
            RedActive = true;
            Green.SetActive(false);
            Red.enabled = true;
        }

        if (time == 0)
        {
            RandomNumber = Random.Range(0, 3);
        }
        else if (time >= 2)
        {
            time = 0;
            RandomNumber = Random.Range(0, 3);
        }
    }

    void OnTriggerEnter()
    {
        if (RedActive) 
        {
            script1.ScoreSubtract10();
            SubtractOBJ.position = transform.position;
            Subtract.Play();
        }
    }
}
