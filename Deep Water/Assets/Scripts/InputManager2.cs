using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager2 : MonoBehaviour
{
    public GameObject player;
    public float drift;
    public float xPosition = -17;
    public Vector3 pos;
    // Update is called once per frame
    void Update()
    {
        PlayerInput();
    }

    public void PlayerInput()
    {
        Vector3 pos = GetComponent<Rigidbody2D>().position;
        pos.x = Mathf.MoveTowards(pos.x, xPosition, drift * Time.deltaTime);
        GetComponent<Rigidbody2D>().position = pos;

        if (Input.GetMouseButtonDown(0))
        {
            StartCoroutine(Rotate(Vector3.up, 180, 0.2f));

            if (pos.x < 5)
            {
                xPosition = 17;
            }
            else if (pos.x >= 5)
            {
                xPosition = -17;
            }
        }
    }

    IEnumerator Rotate(Vector3 axis, float angle, float duration = 1.0f)
    {
        Quaternion from = transform.rotation;
        Quaternion to = transform.rotation;
        to *= Quaternion.Euler(axis * angle);

        float elapsed = 0.0f;
        while (elapsed < duration)
        {
            transform.rotation = Quaternion.Slerp(from, to, elapsed / duration);
            elapsed += Time.deltaTime;
            yield return null;
        }
        transform.rotation = to;
    }

}