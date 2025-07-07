using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectManager : MonoBehaviour
{

    int childCount = 0;
    [HideInInspector] public bool allCollected=false;
    [SerializeField] private int x;
    void Start()
    {
        childCount=transform.childCount;

    }
    void Update()
    {
        //check if the count of child objects has changed;

        if (transform.childCount < childCount)
        {
            Debug.Log("A child has been destroyed");
            childCount=transform.childCount;

            if (childCount == 0)
            {
                allCollected = true;
            }
        }
    }
}
