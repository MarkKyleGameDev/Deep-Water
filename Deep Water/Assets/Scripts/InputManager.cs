using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    //public GameObject player;
    //public float drift;
    //private float speed = 50;
    //public Vector3 aPosition = new Vector3(-17.0f, 0.0f, 0.0f);
    //public Vector3 bPosition = new Vector3(17.0f, 0.0f, 0.0f);

    //public Vector3 pos;
    //private Transform tf;
    //private Rigidbody2D rb;


    //public int xPosition;

    public int laneNumber = 0;
    public int lanesCount = 2;
    bool didChangeLastFrame = false;
    public float laneDistance = 34;
    public float firstLaneXPos = -17;
    public float deadZone = 0.1f;
    public float sideSpeed = 20;


    // Use this for initialization

    void Start()
    {
        //player.transform.position = new Vector3(-17.0f, -5.0f, 0);
        //xPosition = GetComponent<Rigidbody2D>().position.x;
    }

    // Update is called once per frame
    void Update()
    {
        PlayerInput();
        //player.GetComponent<Rigidbody2D>().velocity = Vector2.down;

    }


    public void PlayerInput()
    {
        //move = Vector3.Lerp (move, Vector3.zero, decelerate * Time.deltaTime);


        //float input = Input.GetAxis("Horizontal");
        //pos = tf.position;

        //pos = GetComponent<Rigidbody2D>().position;
        //pos.x = Mathf.MoveTowards(pos.x, xPosition, drift * Time.deltaTime);
        //GetComponent<Rigidbody2D>().position = pos;

        /*Quaternion rot = transform.rotation;
		float y = rot.eulerAngles.y;
		y -= Input.GetAxis ("Horizontal") * rotSpeed * Time.deltaTime;
		rot = Quaternion.Euler (0, y, 0);
		transform.rotation = rot;
		Vector3 pos = transform.position;
		Vector3 velocity = transform.forward * Input.GetAxis("Vertical") * speed * Time.deltaTime;
		pos += velocity;
		transform.position = pos;*/


        float input = Input.GetAxis("Horizontal");
        //bool input = Input.GetMouseButtonDown(0);

        //if (Input.GetMouseButtonDown(0))
        //{
            if (Mathf.Abs(input) > deadZone)
            {
                if (!didChangeLastFrame)
                {
                    didChangeLastFrame = true; //Prevent overshooting lanes
                    laneNumber += Mathf.RoundToInt(Mathf.Sign(input));
                    if (laneNumber < -17) laneNumber = 0;
                    else if (laneNumber >= lanesCount) laneNumber = lanesCount - 1;
                }
            }
            else
            {
                didChangeLastFrame = false;
                //The user hasn't pressed a direction this frame, so allow changing directions next frame.
            }

            Vector3 pos = transform.position;
            pos.x = Mathf.Lerp(pos.x, firstLaneXPos + laneDistance * laneNumber, Time.deltaTime * sideSpeed);
            transform.position = pos;
        //}

        /*if (Input.GetMouseButtonDown(0))
        {
            if (pos.x < 5)
            {
                //pos.x = Mathf.MoveTowards(pos.x, -xPosition, drift * Time.deltaTime);
                xPosition = 17;
                //pos = Vector3.Lerp(pos, bPosition, Time.deltaTime * drift);
            }

            else if (pos.x >= 5)
            {
                //pos.x = Mathf.MoveTowards(pos.x, xPosition, drift * Time.deltaTime);
                xPosition = -17; 
                //pos = Vector3.Lerp(pos, aPosition, Time.deltaTime * drift);
            }*/
        //transform.Translate(transform.forward * speed * Time.deltaTime);
        //gameObject.GetComponent<Rigidbody2D>().AddForce(transform.up * speed * Time.deltaTime, ForceMode2D.Impulse);
    }



}
    

