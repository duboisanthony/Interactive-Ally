using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class planeDestroy : MonoBehaviour
{

    //public float hoverForce = 12f;
    //public GameObject Player;
    public float moveSpeed = 14f;
    // Vector3 upVec = new Vector3(transform.position.x, transform.position.y + 10, transform.position.z);
    public float levelLoaderDelay = 3.0f;
    public bool GoDown = false;
    //private Object c;

    float timeLeft;

    void Update()
    {
        if (GoDown)
        {
            //timeLeft = 5;

            //yield return new WaitForSeconds(2);
            //Object.Destroy(c);
            float step = moveSpeed * Time.deltaTime;
            transform.position += Vector3.down * step;
        }

        //timeLeft -= Time.deltaTime;
        //if (timeLeft < 0)
        //{
        //    StartCoroutine("Lose", "backup");
            //GameOver();
        //}
    }

    void OnTriggerEnter(Collider other)
    {
        //Debug.Log("hello22?");
        if (other.tag == "humain" || other.tag == "Player")
        {
            GoDown = true;

            StartCoroutine("Lose", "backup");
        }
    }

    void OnTriggerStay(Collider other)
    {
        //other.GetComponent<Rigidbody>().AddForce(Vector3.up * hoverForce, ForceMode.Acceleration);
        Debug.Log("Object is within the trigger");
    }

    void OnTriggerExit(Collider other)
    {
        Debug.Log("Object Exited the trigger");
    }

    IEnumerator Lose(string level)
    {
        Debug.Log("LOST PAYLOAD, WILL LOAD LEVEL: " + level);
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene("backup");
    }
}
