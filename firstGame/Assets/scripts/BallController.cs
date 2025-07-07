using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{








    public float speed;
    void Update()
    {
      float hInput =   Input.GetAxis("Horizontal");
      float vInput = Input.GetAxis("Vertical");

      Vector3 movement= new Vector3(hInput,0.0f,vInput) * speed * Time.deltaTime;

      Rigidbody rb= GetComponent<Rigidbody>();
     rb.AddForce(movement,ForceMode.Impulse);
    }
}
