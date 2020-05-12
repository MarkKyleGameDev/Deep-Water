using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StoreControl : MonoBehaviour
{

    //public Button outfitsBtn;
    //public Button powerupBtn;
    //public Button coinsBtn;

    GameControl gc;
	//UI ui;
	//private bool isPaused;

	//public Button buyCoins100;

	// Use this for initialization
	void Start () {
		//Button oBtn = outfitsBtn.GetComponent<Button> ();
		//Button pBtn = powerupBtn.GetComponent<Button> ();
		//Button cBtn = coinsBtn.GetComponent<Button> ();
		//isPaused = false;
		//ui = FindObjectOfType<UI>();
        gc = FindObjectOfType<GameControl>();
        //gc.coinsAmount = PlayerPrefs.GetInt ("CoinsAmount");
    }
	
	// Update is called once per frame
	void Update () {

        gc.coinsAmountText.text = gc.coinsAmount.ToString();

    }

	public void buyCoins25()
	{
		gc.coinsAmount += 25;
	}
	public void buyCoins100()
	{
		gc.coinsAmount += 100;
	}
    public void buyCoins300()
    {
        gc.coinsAmount += 300;
    }
    public void buyCoins550()
	{
		gc.coinsAmount += 550;
	}
	public void buyCoins1200()
	{
		gc.coinsAmount += 1200;
	}
	public void buyCoins2500()
	{
		gc.coinsAmount += 2500;
	}
    






	/*
	public void sections()
	{
		switch (s) {
		case ui.outfitsScreen:
			ui.outfitsScreen.SetActive (true);
			ui.powerupsScreen.SetActive (false);
			ui.coinsScreen.SetActive (false);
			break;
		case ui.powerupsScreen:
			ui.powerupsScreen.SetActive (true);
			ui.outfitsScreen.SetActive (false);
			ui.coinsScreen.SetActive (false);
			break;
		case ui.coinsScreen:
			ui.coinsScreen.SetActive (true);
			ui.outfitsScreen.SetActive (false);
			ui.outfitsScreen.SetActive (false);
		}
	}*/

	/*
	public void outfitsScreen()
	{
		Button oBtn = outfitsBtn.GetComponent<Button>();
		oBtn.onClick.AddListener(oScreen);
		//Time.timeScale = 0.0f;
		//isPaused = !isPaused;
	}

	public void powerupsScreen()
	{
		Button pBtn = powerupBtn.GetComponent<Button>();
		pBtn.onClick.AddListener (pScreen);
		//Time.timeScale = 0.0f;
		//isPaused = !isPaused;
	}

	public void coinsScreen()
	{
		Button cBtn = coinsBtn.GetComponent<Button>();
		cBtn.onClick.AddListener (cScreen);
		//Time.timeScale = 0.0f;
		//isPaused = !isPaused;
	}
	void oScreen()
	{
		ui.outfitsScreen.SetActive (true);
		ui.powerupsScreen.SetActive (false);
		ui.coinsScreen.SetActive (false);
	}

	void pScreen()
	{
		ui.powerupsScreen.SetActive (true);
		ui.outfitsScreen.SetActive (false);
		ui.coinsScreen.SetActive (false);
	}

	void cScreen()
	{
		ui.coinsScreen.SetActive (true);
		ui.outfitsScreen.SetActive (false);
		ui.outfitsScreen.SetActive (false);
	}
	*/

}
