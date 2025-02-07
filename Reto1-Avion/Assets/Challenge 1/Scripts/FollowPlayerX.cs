using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;

public class FollowPlayerX : MonoBehaviour
{
    public GameObject plane;

    private UnityEngine.Vector3 offset = new UnityEngine.Vector3(30, 0, 10);
    /*
    System.Numerics.Vector3*/

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.position = plane.transform.position + offset;
    }
}
