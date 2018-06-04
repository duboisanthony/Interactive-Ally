using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Humain : MonoBehaviour {
    /*
    public GameObject StartingNode;
    public GameObject CurrentNode;
    public GameObject TargetNode;

    public float moveSpeed = 0f;

    public int a;

    public CharControllerAutomate c;
    public voisin LeVoisin;
    public Humain h;

    Vector3 forward, right;

    // Use this for initialization
    void Awake()
    {
        transform.position = StartingNode.transform.position;
    }

    void Start()
    {
        LeVoisin = (voisin)CurrentNode.GetComponent(typeof(voisin));
        //forward = Camera.main.transform.forward;
        //forward.y = 0;
        //forward = Vector3.Normalize(forward);
        //right = Quaternion.Euler(new Vector3(0, 90, 0)) * forward;
    }

    // Update is called once per frame
    void Update()
    {
        //if (Input.anyKey)
        //    Move();
        float step = moveSpeed * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, TargetNode.transform.position, step);

        if ((transform.position.x == TargetNode.transform.position.x) && (transform.position.z == TargetNode.transform.position.z))
        {
            CurrentNode = TargetNode;
            LeVoisin = (voisin)CurrentNode.GetComponent(typeof(voisin));
        }

        if (a == 1)
        {
            MoveUp();
        }

        if (a == 1)
        {
            MoveDown();
        }

        if (a == 1)
        {
            MoveEast();
        }

        if (a == 1)
        {
            MoveWest();
        }
    }

    void MoveUp()
    {
        TargetNode = LeVoisin.North;
    }

    void MoveDown()
    {
        TargetNode = LeVoisin.South;
    }

    void MoveEast()
    {
        TargetNode = LeVoisin.East;
    }

    void MoveWest()
    {
        TargetNode = LeVoisin.West;
    }

    void Move()
    {
        Vector3 direction = new Vector3(Input.GetAxis("HorizontalKey"), 0, Input.GetAxis("VerticalKey"));
        Vector3 rightMovement = right * moveSpeed * Time.deltaTime * Input.GetAxis("HorizontalKey");
        Vector3 upMovement = forward * moveSpeed * Time.deltaTime * Input.GetAxis("VerticalKey");

        Vector3 heading = Vector3.Normalize(rightMovement + upMovement);

        transform.forward = heading;
        transform.position += rightMovement;
        transform.position += upMovement;
    }
    */
}
