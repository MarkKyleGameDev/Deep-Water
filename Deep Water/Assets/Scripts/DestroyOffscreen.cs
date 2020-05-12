using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOffscreen : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D col)
    {
        if (gameObject.CompareTag("OffScreenDestroy"))
        {
            Destroy(col.gameObject);
        }
    }

}