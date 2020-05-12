using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class Audio : MonoBehaviour {

	//static bool AudioBegin = false;
	//public GameObject music;
	//public AudioSource musicPlayer;

	//Audio au;

	//public GameObject musicSource;
	public bool musicToggle;

	public AudioSource whiteLineHitSound;
    //public AudioSource redLineHitSound;
    //public AudioSource blackLineHitSound;

    //public bool soundToggle;

    public AudioSource musicSource;
	//public AudioSource soundSource;
	//public AudioSource audio = GetComponent<AudioSource>;

	private static Audio instance = null;
	public static Audio Instance 

	{
		get{return instance;}
	}
		
	void Start(){
		musicSource = GetComponent<AudioSource> ();
		//soundSource = GetComponent<AudioSource> ();
	}

	// Use this for initialization
	void Awake () 
	{
		if(instance != null && instance != this)
		{
			Destroy(this.gameObject);
			return;
		}
		else
		{
			instance = this;
		}
		DontDestroyOnLoad(this.gameObject);
		/*if (!AudioBegin)
		{
			musicP.Play ();
			DontDestroyOnLoad (gameObject);
			AudioBegin = true;
		}*/

		/*music = GameObject.Find ("MUSIC");

		if (music == null) 
		{
			music = this.gameObject;
			music.name = "MUSIC";
			DontDestroyOnLoad (music);
		} 
		else 
		{
			if (this.gameObject.name != "MUSIC") 
			{
				Destroy (this.gameObject);
			}
		}*/
	}
	
	// Update is called once per frame

	/*void Update () {
		if (Application.loadedLevelName == "Shop")
		{
			//musicP.Stop();
			AudioBegin = false;
			//Destroy (this.gameObject);
		}
		if (Application.loadedLevelName == "Challenges")
		{
			//musicP.Stop();
			AudioBegin = false;
			//Destroy (this.gameObject);
		}
		if (Application.loadedLevelName == "World1")
		{
			//musicP.Stop();
			AudioBegin = false;
			//Destroy (this.gameObject);
		}
	}*/
}
