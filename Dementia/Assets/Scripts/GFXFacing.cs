using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GFXFacing : MonoBehaviour
{
    public Transform target;

    private void Start()
    {
        target = GameObject.Find("Main Camera").GetComponent<Transform>();
    }

    void Update()
    {
        // Rotate the camera every frame so it keeps looking at the target
        //transform.LookAt(target);

        transform.LookAt(Camera.main.transform.position, Vector3.up);
    }
}
