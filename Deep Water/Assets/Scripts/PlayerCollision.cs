using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    GameControl gc;
    InputManager2 im;
    Audio au;

    private float maxSpeed = -30;

    private void Start()
    {
        gc = FindObjectOfType<GameControl>();
        im = FindObjectOfType<InputManager2>();
        au = FindObjectOfType<Audio>();

        au.whiteLineHitSound = GetComponent<AudioSource>();
        //au.redLineHitSound = GetComponent<AudioSource>();
        //au.blackLineHitSound = GetComponent<AudioSource>();
    }

    private void Update()
    {
        if (gc.score > gc.highscore)
        {
            gc.highscore = gc.score;
        }
        this.GetComponent<Rigidbody2D>().gravityScale += 0.01f;
    }

    void OnTriggerEnter2D(Collider2D col)
    {

        if (col.gameObject.CompareTag("WhiteLine"))
        {
            Debug.Log("Hit White");
            gc.score += 1;
            au.whiteLineHitSound.Play(0);
            au.whiteLineHitSound.pitch = (Random.Range(0.8f, 1.2f));
            Destroy(col.gameObject);
        }

        if (col.gameObject.CompareTag("RedLine"))
        {
            Debug.Log("Hit Red");
            au.whiteLineHitSound.Play(0);
            au.whiteLineHitSound.pitch = (Random.Range(0.8f, 1.2f));
            gc.gameOver();
        }

        if (col.gameObject.CompareTag("BlackLine"))
        {
            if (this.GetComponent<Rigidbody2D>().gravityScale > maxSpeed)
            {
                this.GetComponent<Rigidbody2D>().gravityScale -= 0.4f;
            }
            Debug.Log("Hit Black");
            if (im.pos.x < 0)
            {
                im.xPosition = -17;
            }
            if (im.pos.x >= 0)
            {
                im.xPosition = 17;
            }
        }

        if (col.gameObject.CompareTag("Coin"))
        {
            Debug.Log("Coin Collected");
            Destroy(col.gameObject);
            gc.coinsAmount += 5;
        }

        if (col.gameObject.CompareTag("Hook"))
        {
            Debug.Log("Coin Collected");
            gc.gameOver();
        }
        
    }

}


/* private void OnCollisionEnter(Collision col)
{
 Vector3 pos = GetComponent<Rigidbody2D>().position;
 pos.x = Mathf.MoveTowards(pos.x, xPosition, drift * Time.deltaTime);
 GetComponent<Rigidbody2D>().position = pos;

 if (col.gameObject.CompareTag("BlackLine") && pos.x < 5)
 {
     Debug.Log("Hit Black");
     xPosition = -17;

     //Gives player a little boost
     //int magnitude = 2500;
     //Vector3 force = transform.position - col.transform.position;
     //force.Normalize();
     //gameObject.GetComponent<Rigidbody2D>().AddForce(force * magnitude);



     //Vector3 direction = (transform.position - col.transform.position).normalized;
     //float speed = rb.velocity.magnitude;
     //col.gameObject.GetComponent<Rigidbody2D>().AddForce(-direction * speed);
     //rb.velocity = -direction * speed;
     //gameObject.GetComponent<Rigidbody2D>().AddForce(-force * magnitude);

     //rb.AddForce(pushLeft * bounceForce, ForceMode2D.Impulse);
     //gameObject.GetComponent<Rigidbody2D>().velocity = -knockbackVelocity;
 }
 else if (col.gameObject.CompareTag("BlackLine") && pos.x > 5)
 {
     xPosition = 17;
 }
 /*void OnCollisionEnter(Collision coll)
 {
     if (coll.gameObject.CompareTag("BlackLine"))
     {
         Debug.Log("Hit Black");
         rb.AddForce(Vector2.left * bounceForce, ForceMode2D.Impulse);
     }
 }*/

//***************TESTING**********************
/*Vector3 lineStartPosition = new Vector3(0, 0, 0);
Vector3 lineEndPosition = new Vector3(0, 10, 0);

RaycastHit hit;
if (Physics.Raycast(lineStartPosition, lineEndPosition - lineStartPosition, out hit))
{
    switch (hit.transform.gameObject.tag)
    {
        case "BlackLine":
            //Output message
            print("player detected");
            break;
    }
}*/


/*if (col.GetComponent<Collider2D>().tag == "WhiteLine") 
{
    Destroy (gameObject);
    Debug.Log ("Hit White");
}

if (col.GetComponent<Collider2D>().tag == "RedLine") 
{
    Destroy (gameObject);
}*/
//***************TESTING***********************

//}

//}

