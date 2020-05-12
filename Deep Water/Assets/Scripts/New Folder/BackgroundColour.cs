using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundColour : MonoBehaviour
{
    public Camera cam;
    public Color color1;
    public Color color2;

    float time;
    float time2;
    float transition;

    int firstColor = 0;

   
    void Start()
    {
        cam = GetComponent<Camera>();
        //cam.clearFlags = CameraClearFlags.SolidColor;
    }
    void Update()
    {
        if (firstColor == 0)
        {
            color1 = Random.ColorHSV(Random.value, Random.value);
            color2 = Random.ColorHSV(Random.value, Random.value);

            firstColor = 1;
        }
        //GetComponent<BackgroundColour>().cam = ;
        
        //cam = Color.Lerp(color2, color1, transition);
        //cam.GetComponent<BackgroundColour> 
        
        time += Time.deltaTime;
        time2 += Time.deltaTime;
        
        transition = time2 / 5;

        if (time > 5)
        {
            color2 = color1;
            color1 = Random.ColorHSV(Random.value, Random.value);

            time = 0;
            time2 = 0;
            transition = 0;
        }
    }
}
