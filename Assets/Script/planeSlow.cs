using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class planeSlow : MonoBehaviour
{

    public CharControllerAutomate c;
    //public float hoverForce = 12f;
    //public GameObject Player;
    //public float moveSpeed = 14f;
    // Vector3 upVec = new Vector3(transform.position.x, transform.position.y + 10, transform.position.z);

    void OnTriggerEnter(Collider other)
    {
        //Debug.Log("hello22?");
        if ((other.tag == "humain")|| (other.tag == "Player"))
        {
            c.moveSpeed = 3f;
        }
    }

    void OnTriggerExit(Collider other)
    {
        //Debug.Log("Object Exited the trigger");
        c.moveSpeed = 14f;
    }
}