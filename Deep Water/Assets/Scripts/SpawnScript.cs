using UnityEngine;
using System.Collections;

public class SpawnScript : MonoBehaviour
{
    public GameObject[] obj;

	float spawnMinSpeed = 0.1f;
    float spawnMaxSpeed = 0.1f;

	public float lineSizeMin = 0.4f;
	public float lineSizeMax = 1.5f;

	float previousYScale;
	float previousYPosition;
    
    public Vector3 spawnPos = new Vector3(0.0f,50.0f,0.0f); 

    // Use this for initialization
    void Start()
    {
        SpawnLine();
    }

    // Update is called once per frame 
    public void SpawnLine()
    {
        //Instantiates random line (white, black or red)
        GameObject line = Instantiate(obj[Random.Range(0, obj.GetLength(0))], spawnPos, Quaternion.identity);

        //Gets random line size between 0.4 and 1.5, only changes Y axis
        Vector3 randomSize = new Vector3(0, Random.Range(lineSizeMin, lineSizeMax), 0);

        // Sets scale of current line GameObject using randomSize
        line.transform.localScale = randomSize;

        //Gets Scale and Position of previous line spawned
        previousYScale = line.transform.localScale.y;
		previousYPosition = spawnPos.y;

		//Sets new spawn position to top of the previous position
		spawnPos = new Vector3 (0, previousYPosition + (previousYScale * 10), 0);

		//Determines the speed of the line spawns
        Invoke("SpawnLine", Random.Range(spawnMinSpeed, spawnMaxSpeed));

        //Deletes lines after a certain time (Change "15" here for time it takes to delete generated lines) 
        //Object.Destroy (line, spawnMaxSpeed+10f);

        //********TESTING*********************
        // = instantiatedPerson.AddComponent<BoxCollider>();

        //nd = instantiatedPerson.AddComponent<Renderer>();

        //.size = new Vector3(rend.bounds.size.x, rend.bounds.size.y, rend.bounds.size.z);


        //BoxCollider2D collider = line.AddComponent<BoxCollider2D>();
        //collider.isTrigger = true;
        //collider.offset = new Vector3(1, 10, 0);
        //collider.bounds.SetMinMax(min, max);
        //********TESTING*******************************

    }
}