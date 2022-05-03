using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKey(KeyCode.Z))
        {
            GetComponent<Rigidbody>().MovePosition(transform.position + Vector3.forward * 0.1f);
        }
        if (Input.GetKey(KeyCode.S))
        {
            GetComponent<Rigidbody>().MovePosition(transform.position + Vector3.forward * (-0.1f));
        }
        if (Input.GetKey(KeyCode.Q))
        {
            GetComponent<Rigidbody>().MovePosition(transform.position + Vector3.left * 0.1f);
        }
        if (Input.GetKey(KeyCode.D))
        {
            GetComponent<Rigidbody>().MovePosition(transform.position + Vector3.right * 0.1f);
        }
                
    }
}