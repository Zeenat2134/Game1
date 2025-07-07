using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject ballPrefab;
    public Transform instantiatePos;
    public camera CameraFollow;
    void Start()
    {

        GameObject pl = Instantiate(ballPrefab, instantiatePos.position, Quaternion.identity);
        CameraFollow.target = pl.transform;
    }

}
