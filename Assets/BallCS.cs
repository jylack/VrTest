using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallCS : MonoBehaviour
{
    Vector3 startPos;

    void Start()
    {
        startPos = transform.position;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            ReSetPos();
        }
    }

    public void ReSetPos()
    {
        transform.position = startPos;
        transform.rotation = Quaternion.identity;
        GetComponent<Rigidbody>().velocity = Vector3.zero;
    }

}
