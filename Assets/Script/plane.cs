using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class plane : MonoBehaviour {

    //public float hoverForce = 12f;
    //public GameObject Player;
    public float moveSpeed = 14f;
    // Vector3 upVec = new Vector3(transform.position.x, transform.position.y + 10, transform.position.z);
    public bool GoUp = false;
    public float levelLoaderDelay = 3.0f;

    void Update()
    {
        if (GoUp)
        {
            float step = moveSpeed * Time.deltaTime;
            transform.position += Vector3.up * step;
        }
    }

    void OnTriggerEnter (Collider other)
    {

        //Debug.Log("hello22?");
        if (other.tag == "humain")
        {
            GoUp = true;

            StartCoroutine("goToLevel", "Scene 2");
        }
        //if (other.tag == "elevator")
        //{
        //    SceneManager.LoadScene("Scene 2");
        //    Debug.Log("hello?");
        //}
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

    IEnumerator goToLevel(string level)
    {
        Debug.Log("LOST PAYLOAD, WILL LOAD LEVEL: " + level);
        yield return new WaitForSeconds(levelLoaderDelay);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
