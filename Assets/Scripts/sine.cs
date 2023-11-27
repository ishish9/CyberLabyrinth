using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sine : MonoBehaviour
{
    public float x;
    public float y;
    public float z;
    public float xSin;
    public float ySin;
    public float zSin;
    public float Move;
    public float Distance;
    public bool xbool;
    public bool ybool;
    public bool zbool;
    public bool zboolALT;
    public bool xboolALT;

    private Vector3 StartPosition;

    [SerializeField] private float frequency = 5f;
    [SerializeField] private float magnitude = 5f;
    [SerializeField] private float offset = 0f;


    private void Start()
    {
        StartPosition = transform.position;
    }

    void Update()
    {
        if (xbool)
        {
            x = Mathf.Sin(Time.time * xSin) * Distance;
            transform.position = new Vector3(x + Move, transform.position.y, transform.position.z);
        }

        if (ybool)
        {
            y = Mathf.Sin(Time.time * ySin) * Distance;
            transform.position = new Vector3(transform.position.x, y + Move , transform.position.z);
        }

        if (zbool)
        {
            z = Mathf.Sin(Time.time * zSin) * Distance;
            transform.position = new Vector3(transform.position.x, transform.position.y, z + Move);
        }

        if (zboolALT)
        {
            z = Mathf.Sin(Time.time * zSin) * Distance;
            transform.position = StartPosition + transform.right * Mathf.Sin(Time.time * frequency + offset) * magnitude;
        }

        if (xboolALT)
        {
            z = Mathf.Sin(Time.time * zSin) * Distance;
            transform.position = StartPosition + transform.up * Mathf.Sin(Time.time * frequency + offset) * magnitude;
        }

    }
}
