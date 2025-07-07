using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera : MonoBehaviour
{
    public Transform target;
    public Vector3 offset;
    // Start is called before the first frame update
    
    //position of camera = position of target+offset

    void Update(){
        transform.position =target.position + offset;
    }
}
