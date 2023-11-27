using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controller : MonoBehaviour
{
    private Rigidbody rigid;
    private float speed = 280f;
    public float speed2 = 280f;
    private float h;
    private float v;

    private void Start()
    {
        rigid = gameObject.GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        //Keyboard Controls Code//

        if (Input.GetAxis("Horizontal") > 0)
        {
            rigid.AddForce(Vector3.right * speed2 * Time.deltaTime, ForceMode.Impulse);
        }
        else if (Input.GetAxis("Horizontal") < 0)
        {
            rigid.AddForce(-Vector3.right * speed2 * Time.deltaTime, ForceMode.Impulse);
        }

        if (Input.GetAxis("Vertical") > 0)
        {
            rigid.AddForce(Vector3.forward * speed2 * Time.deltaTime, ForceMode.Impulse);
        }
        else if (Input.GetAxis("Vertical") < 0)
        {
            rigid.AddForce(-Vector3.forward * speed2 * Time.deltaTime, ForceMode.Impulse);
        }

        Vector3 dir = Vector3.zero;
        //Accelerometer Controls Code//
        //if (Application.isMobilePlatform)
        { 
        h = Input.acceleration.x * speed;
        v = Input.acceleration.y * speed;
            
            //rigid.AddForce(new Vector3(h, -34f, v) * speed * Time.fixedDeltaTime, ForceMode.Impulse);
        }
    }
}




//*Accelerometer Controls Code//

//h = Input.acceleration.x * speed2;//4
//v = Input.acceleration.y * speed2;//4

//if (Application.isMobilePlatform && rigid.velocity.magnitude > max)
//{
  //  rigid.velocity = new Vector3(h, 0f, v) * Time.fixedDeltaTime;// *speed2
    //rigid.AddForce(new Vector3(0f, -150f, 0f) * Time.fixedDeltaTime, ForceMode.Impulse);
//}
        // rigid.AddForce(new Vector3(h, 0.0f, v) * speed2 * Time.fixedDeltaTime, ForceMode.Impulse);
  //  }
//
