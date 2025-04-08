using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AreaCtrl : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Out of Area");
        if (collision.gameObject.tag ==  ("Ball"))
        {
            collision.gameObject.GetComponent<BallCS>().ReSetPos();
        }
    }

    

}
