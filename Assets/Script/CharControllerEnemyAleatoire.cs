using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CharControllerEnemyAleatoire : MonoBehaviour
{

    public GameObject StartingNode;
    public GameObject CurrentNode;
    public GameObject TargetNode;
    public Sprite[] MySpriteArray;
    public Sprite MySprite;

    public voisin LeVoisin;

    public float moveSpeed = 14f;

    public int random;

    private SpriteRenderer MySpriteRenderer;

    Vector3 forward, right;

    // Use this for initialization
    void Awake()
    {
        transform.position = StartingNode.transform.position;
    }

    void Start()
    {
        LeVoisin = (voisin)CurrentNode.GetComponent(typeof(voisin));
        MySpriteRenderer = this.gameObject.GetComponentInChildren<SpriteRenderer>();
        MySprite = MySpriteArray[0];
        MySpriteRenderer.sprite = MySprite;
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
        MySpriteRenderer.transform.LookAt(Camera.main.transform.position, Vector3.up);

        if ((transform.position.x == TargetNode.transform.position.x) && (transform.position.z == TargetNode.transform.position.z))
        {
            CurrentNode = TargetNode;
            LeVoisin = (voisin)CurrentNode.GetComponent(typeof(voisin));
        }

        if ((Input.GetKey(KeyCode.UpArrow))||(Input.GetKey(KeyCode.DownArrow))||(Input.GetKey(KeyCode.RightArrow)) ||(Input.GetKey(KeyCode.LeftArrow)))
        {
            random = Random.Range(1,5);
            if (random == 1)
            {
                MoveUp();
            }

            if (random == 2)
            {
                MoveDown();
            }

            if (random == 3)
            {
                MoveEast();
            }

            if (random == 4)
            {
                MoveWest();
            }
        }
    }

    void MoveUp()
    {
        if (LeVoisin.North != null)
        {
            TargetNode = LeVoisin.North;
            MySprite = MySpriteArray[0];
            MySpriteRenderer.sprite = MySprite;
        }
    }

    void MoveDown()
    {
        if (LeVoisin.South != null)
        {
            TargetNode = LeVoisin.South;
            MySprite = MySpriteArray[1];
            MySpriteRenderer.sprite = MySprite;
        }
    }

    void MoveEast()
    {
        if (LeVoisin.East != null)
        {
            TargetNode = LeVoisin.East;
            MySprite = MySpriteArray[2];
            MySpriteRenderer.sprite = MySprite;
        }
    }

    void MoveWest()
    {
        if (LeVoisin.West != null)
        {
            TargetNode = LeVoisin.West;
            MySprite = MySpriteArray[3];
            MySpriteRenderer.sprite = MySprite;
        }
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
    void OnTriggerEnter(Collider other)
    {

        //Debug.Log("hello22?");
        if ((other.tag == "humain") || (other.tag == "Player"))
        {
            SceneManager.LoadScene("backup");
        }
    }
}