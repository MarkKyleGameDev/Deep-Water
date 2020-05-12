using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerCustomisationControl : MonoBehaviour
{
    GameControl gc;

    #region Skins Variables
    //***********SKINS*********************
    private int isSkin1Sold = 0;
    private int isSkin2Sold = 0;
    private int isSkin3Sold = 0;
    private int isSkin4Sold = 0;
    private int isSkin5Sold = 0;
    private int isSkin6Sold = 0;

    public Text skin2Price;
    public Text skin3Price;
    public Text skin4Price;
    public Text skin5Price;
    public Text skin6Price;

    public Button buySkin2Button;
    public Button buySkin3Button;
    public Button buySkin4Button;
    public Button buySkin5Button;
    public Button buySkin6Button;
    
    public Button equipSkin1Button;
    public Button equipSkin2Button;
    public Button equipSkin3Button;
    public Button equipSkin4Button;
    public Button equipSkin5Button;
    public Button equipSkin6Button;

    public int isSkin1Equipped = 0;
    public int isSkin2Equipped = 0;
    public int isSkin3Equipped = 0;
    public int isSkin4Equipped = 0;
    public int isSkin5Equipped = 0;
    public int isSkin6Equipped = 0;

    public GameObject skin1;
    public GameObject skin2;
    public GameObject skin3;
    public GameObject skin4;
    public GameObject skin5;
    public GameObject skin6;

    #endregion

    #region Trails Variables
    //***********TRAILS*********************
    private int isTrail1Sold = 0;
    private int isTrail2Sold = 0;
    private int isTrail3Sold = 0;
    private int isTrail4Sold = 0;
    private int isTrail5Sold = 0;
    private int isTrail6Sold = 0;

    public Text trail2Price;
    public Text trail3Price;
    public Text trail4Price;
    public Text trail5Price;
    public Text trail6Price;

    public Button buyTrail2Button;
    public Button buyTrail3Button;
    public Button buyTrail4Button;
    public Button buyTrail5Button;
    public Button buyTrail6Button;

    public Button equipTrail1Button;
    public Button equipTrail2Button;
    public Button equipTrail3Button;
    public Button equipTrail4Button;
    public Button equipTrail5Button;
    public Button equipTrail6Button;

    public int isTrail1Equipped = 0;
    public int isTrail2Equipped = 0;
    public int isTrail3Equipped = 0;
    public int isTrail4Equipped = 0;
    public int isTrail5Equipped = 0;
    public int isTrail6Equipped = 0;

    public GameObject trail1;
    public GameObject trail2;
    public GameObject trail3;
    public GameObject trail4;
    public GameObject trail5;
    public GameObject trail6;

    #endregion

    // Start is called before the first frame update
    void Start()
    {
        gc = FindObjectOfType<GameControl>();
        //gc.coinsAmount = PlayerPrefs.GetInt("CoinsAmount");


        //Checks if each item has been purchased
        //Equips selected item
        #region Equip Skins 
        //*********SKINS**************
        if (isSkin1Equipped == 1)
            skin1.SetActive(true);
        else
            skin1.SetActive(false);

        if (isSkin2Equipped == 1)
            skin2.SetActive(true);
        else
            skin2.SetActive(false);

        if (isSkin3Equipped == 1)
            skin3.SetActive(true);
        else
            skin3.SetActive(false);

        if (isSkin4Equipped == 1)
            skin4.SetActive(true);
        else
            skin4.SetActive(false);

        if (isSkin5Equipped == 1)
            skin5.SetActive(true);
        else
            skin5.SetActive(false);

        if (isSkin6Equipped == 1)
            skin6.SetActive(true);
        else
            skin6.SetActive(false);
        #endregion

        #region Equip Trails
        //*********TRAILS**************
        if (isTrail1Equipped == 1)
            trail1.SetActive(true);
        else
            trail1.SetActive(false);

        if (isTrail2Equipped == 1)
            trail2.SetActive(true);
        else
            trail2.SetActive(false);

        if (isTrail3Equipped == 1)
            trail3.SetActive(true);
        else
            trail3.SetActive(false);

        if (isTrail4Equipped == 1)
            trail4.SetActive(true);
        else
            trail4.SetActive(false);

        if (isTrail5Equipped == 1)
            trail5.SetActive(true);
        else
            trail5.SetActive(false);

        if (isTrail6Equipped == 1)
            trail6.SetActive(true);
        else
            trail6.SetActive(false);
        #endregion
    }

    // Update is called once per frame
    void Update()
    {
        gc.coinsAmountText.text = gc.coinsAmount.ToString();

        //Checks if player has enough coins to buy each skin/trail
        //When they have the required amount and the item hasn't already been bought, the button to buy becomes interactable
        //When they buy a skin/trail, the button to equip it activates
        #region Skins Eligibility
        //*******************SKIN 1***********************
        isSkin1Sold = PlayerPrefs.GetInt("isSkin1Sold");
        if (isSkin1Sold == 1)
            equipSkin1Button.gameObject.SetActive(true);

        //*******************SKIN 2***********************
        isSkin2Sold = PlayerPrefs.GetInt("isSkin2Sold");
        if (gc.coinsAmount >= 100 && isSkin2Sold == 0)
            buySkin2Button.interactable = true;
        else if (isSkin2Sold == 1 && buySkin2Button.interactable == false)
            equipSkin2Button.gameObject.SetActive(true);
        else
            buySkin2Button.interactable = false;

        //*******************SKIN 3***********************
        isSkin3Sold = PlayerPrefs.GetInt("isSkin3Sold");
        if (gc.coinsAmount >= 150 && isSkin3Sold == 0)
            buySkin3Button.interactable = true;
        else if (isSkin3Sold == 1 && buySkin3Button.interactable == false)
            equipSkin3Button.gameObject.SetActive(true);
        else
            buySkin3Button.interactable = false;

        //*******************SKIN 4***********************
        isSkin4Sold = PlayerPrefs.GetInt("isSkin4Sold");
        if (gc.coinsAmount >= 250 && isSkin4Sold == 0)
            buySkin4Button.interactable = true;
        else if (isSkin4Sold == 1 && buySkin4Button.interactable == false)
            equipSkin4Button.gameObject.SetActive(true);
        else
            buySkin4Button.interactable = false;

        //*******************SKIN 5***********************
        isSkin5Sold = PlayerPrefs.GetInt("isSkin5Sold");
        if (gc.coinsAmount >= 400 && isSkin5Sold == 0)
            buySkin5Button.interactable = true;
        else if (isSkin5Sold == 1 && buySkin5Button.interactable == false)
            equipSkin5Button.gameObject.SetActive(true);
        else
            buySkin5Button.interactable = false;

        //*******************SKIN 6***********************
        isSkin6Sold = PlayerPrefs.GetInt("isSkin6Sold");
        if (gc.coinsAmount >= 500 && isSkin6Sold == 0)
            buySkin6Button.interactable = true;
        else if (isSkin6Sold == 1 && buySkin6Button.interactable == false)
            equipSkin6Button.gameObject.SetActive(true); 
        else
            buySkin6Button.interactable = false;
        //buySkin6Button.interactable = false;
        //else if (isSkin6Sold == 1)
        //Destroy(gameObject);
        #endregion

        #region Trails Eligibility
        //*******************TRAIL 1***********************
        isTrail1Sold = PlayerPrefs.GetInt("isTrail1Sold");
        if (isTrail1Sold == 1)
            equipTrail1Button.gameObject.SetActive(true);

        //*******************TRAIL 2***********************
        isTrail2Sold = PlayerPrefs.GetInt("isTrail2Sold");
        if (gc.coinsAmount >= 75 && isTrail2Sold == 0)
            buyTrail2Button.interactable = true;
        else if (isTrail2Sold == 1 && buyTrail2Button.interactable == false)
            equipTrail2Button.gameObject.SetActive(true);
        else
            buyTrail2Button.interactable = false;

        //*******************TRAIL 3***********************
        isTrail3Sold = PlayerPrefs.GetInt("isTrail3Sold");
        if (gc.coinsAmount >= 175 && isTrail3Sold == 0)
            buyTrail3Button.interactable = true;
        else if (isTrail3Sold == 1 && buyTrail3Button.interactable == false)
            equipTrail3Button.gameObject.SetActive(true);
        else
            buyTrail3Button.interactable = false;

        //*******************TRAIL 4***********************
        isTrail4Sold = PlayerPrefs.GetInt("isTrail4Sold");
        if (gc.coinsAmount >= 225 && isTrail4Sold == 0)
            buyTrail4Button.interactable = true;
        else if (isTrail4Sold == 1 && buyTrail4Button.interactable == false)
            equipTrail4Button.gameObject.SetActive(true);
        else
            buyTrail4Button.interactable = false;

        //*******************TRAIL 5***********************
        isTrail5Sold = PlayerPrefs.GetInt("isTrail5Sold");
        if (gc.coinsAmount >= 300 && isTrail5Sold == 0)
            buyTrail5Button.interactable = true;
        else if (isTrail5Sold == 1 && buyTrail5Button.interactable == false)
            equipTrail5Button.gameObject.SetActive(true);
        else
            buyTrail5Button.interactable = false;
        
        //*******************SKIN 6***********************
        isTrail6Sold = PlayerPrefs.GetInt("isTrail6Sold");
        if (gc.coinsAmount >= 500 && isTrail6Sold == 0)
            buyTrail6Button.interactable = true;
        else if (isTrail6Sold == 1 && buyTrail6Button.interactable == false)
            equipTrail6Button.gameObject.SetActive(true);
        else
            buyTrail6Button.interactable = false;
    }
    #endregion

    //Takes coins from player when buying each skin/trail
    //Disables button so they cannot buy same skin/trail again

    #region Buy Skins
    //*******************BUY SKIN 2**********************
    public void buySkin2()
    {
        gc.coinsAmount -= 100;
        skin2Price.text = "✔";
        //Destroy(buySkin2Button.gameObject);
        buySkin2Button.gameObject.SetActive(false);
        //equipSkin2Button.gameObject.SetActive(true);
        PlayerPrefs.SetInt("isSkin2Sold", 1);
    }

    //*******************BUY SKIN 3**********************
    public void buySkin3()
    {
        gc.coinsAmount -= 150;
        skin3Price.text = "✔";
        //Destroy(buySkin3Button.gameObject);
        buySkin3Button.gameObject.SetActive(false);
        //equipSkin3Button.gameObject.SetActive(true);
        PlayerPrefs.SetInt("isSkin3Sold", 1);
    }

    //*******************BUY SKIN 4**********************
    public void buySkin4()
    {
        gc.coinsAmount -= 250;
        skin4Price.text = "✔";
        buySkin4Button.gameObject.SetActive(false);
        //equipSkin4Button.gameObject.SetActive(true);
        PlayerPrefs.SetInt("isSkin4Sold", 1);
    }

    //*******************BUY SKIN 5**********************
    public void buySkin5()
    {
        gc.coinsAmount -= 400;
        skin5Price.text = "✔";
        buySkin5Button.gameObject.SetActive(false);
        //equipSkin5Button.gameObject.SetActive(true);
        PlayerPrefs.SetInt("isSkin5Sold", 1);
    }

    //*******************BUY SKIN 6**********************
    public void buySkin6()
    {
        gc.coinsAmount -= 500;
        skin6Price.text = "✔";
        buySkin6Button.gameObject.SetActive(false);
        //equipSkin6Button.gameObject.SetActive(true);
        PlayerPrefs.SetInt("isSkin6Sold", 1);
    }
    #endregion

    #region Buy Trails
    //*******************BUY TRAIL 2**********************
    public void buyTrail2()
    {
        gc.coinsAmount -= 75;
        trail2Price.text = "✔";
        //Destroy(buySkin2Button.gameObject);
        buyTrail2Button.gameObject.SetActive(false);
        //equipSkin2Button.gameObject.SetActive(true);
        PlayerPrefs.SetInt("isTrail2Sold", 1);
    }

    //*******************BUY TRAIL 3**********************
    public void buyTrail3()
    {
        gc.coinsAmount -= 175;
        trail3Price.text = "✔";
        //Destroy(buySkin3Button.gameObject);
        buyTrail3Button.gameObject.SetActive(false);
        //equipSkin3Button.gameObject.SetActive(true);
        PlayerPrefs.SetInt("isTrail3Sold", 1);
    }

    //*******************BUY TRAIL 4**********************
    public void buyTrail4()
    {
        gc.coinsAmount -= 225;
        trail4Price.text = "✔";
        buyTrail4Button.gameObject.SetActive(false);
        //equipSkin4Button.gameObject.SetActive(true);
        PlayerPrefs.SetInt("isTrail4Sold", 1);
    }

    //*******************BUY TRAIL 5**********************
    public void buyTrail5()
    {
        gc.coinsAmount -= 300;
        trail5Price.text = "✔";
        buyTrail5Button.gameObject.SetActive(false);
        //equipSkin5Button.gameObject.SetActive(true);
        PlayerPrefs.SetInt("isTrail5Sold", 1);
    }

    //*******************BUY TRAIL 6**********************
    public void buyTrail6()
    {
        gc.coinsAmount -= 500;
        trail6Price.text = "✔";
        buyTrail6Button.gameObject.SetActive(false);
        //equipSkin6Button.gameObject.SetActive(true);
        PlayerPrefs.SetInt("isTrail6Sold", 1);
    }
    #endregion

    //Sets a selected skin/trail to "equipped"
    //Disables the button interactivity of the equipped item 
    #region Equip Skins
    //****************EQUIP SKIN 1*********************
    public void equipSkin1()
    {
        //skin2Price.color = Color.black;
        equipSkin1Button.interactable = false;
        equipSkin2Button.interactable = true;
        equipSkin3Button.interactable = true;
        equipSkin4Button.interactable = true;
        equipSkin5Button.interactable = true;
        equipSkin6Button.interactable = true;
        PlayerPrefs.SetInt("isSkin1Equipped", 1);
        PlayerPrefs.SetInt("isSkin2Equipped", 0);
        PlayerPrefs.SetInt("isSkin3Equipped", 0);
        PlayerPrefs.SetInt("isSkin4Equipped", 0);
        PlayerPrefs.SetInt("isSkin5Equipped", 0);
        PlayerPrefs.SetInt("isSkin6Equipped", 0);
    }

    //****************EQUIP SKIN 2*********************
    public void equipSkin2()
    {
        //skin2Price.color = Color.black;
        equipSkin1Button.interactable = true;
        equipSkin2Button.interactable = false;
        equipSkin3Button.interactable = true;
        equipSkin4Button.interactable = true;
        equipSkin5Button.interactable = true;
        equipSkin6Button.interactable = true;
        PlayerPrefs.SetInt("isSkin1Equipped", 0);
        PlayerPrefs.SetInt("isSkin2Equipped", 1);
        PlayerPrefs.SetInt("isSkin3Equipped", 0);
        PlayerPrefs.SetInt("isSkin4Equipped", 0);
        PlayerPrefs.SetInt("isSkin5Equipped", 0);
        PlayerPrefs.SetInt("isSkin6Equipped", 0);
    }

    //****************EQUIP SKIN 3*********************
    public void equipSkin3()
    {
        //skin3Price.color = Color.black;
        equipSkin1Button.interactable = true;
        equipSkin2Button.interactable = true;
        equipSkin3Button.interactable = false;
        equipSkin4Button.interactable = true;
        equipSkin5Button.interactable = true;
        equipSkin6Button.interactable = true;
        PlayerPrefs.SetInt("isSkin1Equipped", 0);
        PlayerPrefs.SetInt("isSkin2Equipped", 0);
        PlayerPrefs.SetInt("isSkin3Equipped", 1);
        PlayerPrefs.SetInt("isSkin4Equipped", 0);
        PlayerPrefs.SetInt("isSkin5Equipped", 0);
        PlayerPrefs.SetInt("isSkin6Equipped", 0);
    }

    //****************EQUIP SKIN 4*********************
    public void equipSkin4()
    {
        //skin3Price.color = Color.black;
        equipSkin1Button.interactable = true;
        equipSkin2Button.interactable = true;
        equipSkin3Button.interactable = true;
        equipSkin4Button.interactable = false;
        equipSkin5Button.interactable = true;
        equipSkin6Button.interactable = true;
        PlayerPrefs.SetInt("isSkin1Equipped", 0);
        PlayerPrefs.SetInt("isSkin2Equipped", 0);
        PlayerPrefs.SetInt("isSkin3Equipped", 0);
        PlayerPrefs.SetInt("isSkin4Equipped", 1);
        PlayerPrefs.SetInt("isSkin5Equipped", 0);
        PlayerPrefs.SetInt("isSkin6Equipped", 0);
    }

    //****************EQUIP SKIN 5*********************
    public void equipSkin5()
    {
        //skin3Price.color = Color.black;
        equipSkin1Button.interactable = true;
        equipSkin2Button.interactable = true;
        equipSkin3Button.interactable = true;
        equipSkin4Button.interactable = true;
        equipSkin5Button.interactable = false;
        equipSkin6Button.interactable = true;
        PlayerPrefs.SetInt("isSkin1Equipped", 0);
        PlayerPrefs.SetInt("isSkin2Equipped", 0);
        PlayerPrefs.SetInt("isSkin3Equipped", 0);
        PlayerPrefs.SetInt("isSkin4Equipped", 0);
        PlayerPrefs.SetInt("isSkin5Equipped", 1);
        PlayerPrefs.SetInt("isSkin6Equipped", 0);
    }

    //****************EQUIP SKIN 6*********************
    public void equipSkin6()
    {
        //skin3Price.color = Color.black;
        equipSkin1Button.interactable = true;
        equipSkin2Button.interactable = true;
        equipSkin3Button.interactable = true;
        equipSkin4Button.interactable = true;
        equipSkin5Button.interactable = true;
        equipSkin6Button.interactable = false;
        PlayerPrefs.SetInt("isSkin1Equipped", 0);
        PlayerPrefs.SetInt("isSkin2Equipped", 0);
        PlayerPrefs.SetInt("isSkin3Equipped", 0);
        PlayerPrefs.SetInt("isSkin4Equipped", 0);
        PlayerPrefs.SetInt("isSkin5Equipped", 0);
        PlayerPrefs.SetInt("isSkin6Equipped", 1);
    }
    #endregion

    #region Equip Trails
    //****************EQUIP SKIN 1*********************
    public void equipTrail1()
    {
        //skin2Price.color = Color.black;
        equipTrail1Button.interactable = false;
        equipTrail2Button.interactable = true;
        equipTrail3Button.interactable = true;
        equipTrail4Button.interactable = true;
        equipTrail5Button.interactable = true;
        equipTrail6Button.interactable = true;
        PlayerPrefs.SetInt("iTrail1Equipped", 1);
        PlayerPrefs.SetInt("isTrail2Equipped", 0);
        PlayerPrefs.SetInt("isTrail3Equipped", 0);
        PlayerPrefs.SetInt("isTrail4Equipped", 0);
        PlayerPrefs.SetInt("isTrail5Equipped", 0);
        PlayerPrefs.SetInt("isTrailEquipped", 0);
    }

    //****************EQUIP SKIN 2*********************
    public void equipTrail2()
    {
        //skin2Price.color = Color.black;
        equipTrail1Button.interactable = true;
        equipTrail2Button.interactable = false;
        equipTrail3Button.interactable = true;
        equipTrail4Button.interactable = true;
        equipTrail5Button.interactable = true;
        equipTrail6Button.interactable = true;
        PlayerPrefs.SetInt("isTrail1Equipped", 0);
        PlayerPrefs.SetInt("isTrail2Equipped", 1);
        PlayerPrefs.SetInt("isTrail3Equipped", 0);
        PlayerPrefs.SetInt("isTrail4Equipped", 0);
        PlayerPrefs.SetInt("isTrail5Equipped", 0);
        PlayerPrefs.SetInt("isTrail6Equipped", 0);
    }

    //****************EQUIP SKIN 3*********************
    public void equipTrail3()
    {
        //skin3Price.color = Color.black;
        equipTrail1Button.interactable = true;
        equipTrail2Button.interactable = true;
        equipTrail3Button.interactable = false;
        equipTrail4Button.interactable = true;
        equipTrail5Button.interactable = true;
        equipTrail6Button.interactable = true;
        PlayerPrefs.SetInt("isTrail1Equipped", 0);
        PlayerPrefs.SetInt("isTrail2Equipped", 0);
        PlayerPrefs.SetInt("isTrail3Equipped", 1);
        PlayerPrefs.SetInt("isTrail4Equipped", 0);
        PlayerPrefs.SetInt("isTrail5Equipped", 0);
        PlayerPrefs.SetInt("isTrail6Equipped", 0);
    }

    //****************EQUIP SKIN 4*********************
    public void equipTrail4()
    {
        //skin3Price.color = Color.black;
        equipTrail1Button.interactable = true;
        equipTrail2Button.interactable = true;
        equipTrail3Button.interactable = true;
        equipTrail4Button.interactable = false;
        equipTrail5Button.interactable = true;
        equipTrail6Button.interactable = true;
        PlayerPrefs.SetInt("isTrail1Equipped", 0);
        PlayerPrefs.SetInt("isTrail2Equipped", 0);
        PlayerPrefs.SetInt("isTrail3Equipped", 0);
        PlayerPrefs.SetInt("isTrail4Equipped", 1);
        PlayerPrefs.SetInt("isTrail5Equipped", 0);
        PlayerPrefs.SetInt("isTrail6Equipped", 0);
    }

    //****************EQUIP SKIN 5*********************
    public void equipTrail5()
    {
        //skin3Price.color = Color.black;
        equipTrail1Button.interactable = true;
        equipTrail2Button.interactable = true;
        equipTrail3Button.interactable = true;
        equipTrail4Button.interactable = true;
        equipTrail5Button.interactable = false;
        equipTrail6Button.interactable = true;
        PlayerPrefs.SetInt("isTrail1Equipped", 0);
        PlayerPrefs.SetInt("isTrail2Equipped", 0);
        PlayerPrefs.SetInt("isTrail3Equipped", 0);
        PlayerPrefs.SetInt("isTrail4Equipped", 0);
        PlayerPrefs.SetInt("isTrail5Equipped", 1);
        PlayerPrefs.SetInt("isTrail6Equipped", 0);
    }

    //****************EQUIP SKIN 6*********************
    public void equipTrail6()
    {
        //skin3Price.color = Color.black;
        equipTrail1Button.interactable = true;
        equipTrail2Button.interactable = true;
        equipTrail3Button.interactable = true;
        equipTrail4Button.interactable = true;
        equipTrail5Button.interactable = true;
        equipTrail6Button.interactable = false;
        PlayerPrefs.SetInt("isTrail1Equipped", 0);
        PlayerPrefs.SetInt("isTrail2Equipped", 0);
        PlayerPrefs.SetInt("isTrail3Equipped", 0);
        PlayerPrefs.SetInt("isTrail4Equipped", 0);
        PlayerPrefs.SetInt("isTrail5Equipped", 0);
        PlayerPrefs.SetInt("isTrail6Equipped", 1);
    }
    #endregion


    //Resets player preferences (for testing purposes)
    public void resetPlayerPrefs()
    {
        PlayerPrefs.DeleteAll();
        gc.coinsAmount = 0;
        gc.score = 0;
        gc.highscore = 0;

        //***********Reset Skins****************
        buySkin2Button.gameObject.SetActive(true);
        skin2Price.text = "100";
        buySkin3Button.gameObject.SetActive(true);
        skin3Price.text = "150";
        buySkin4Button.gameObject.SetActive(true);
        skin4Price.text = "250";
        buySkin5Button.gameObject.SetActive(true);
        skin5Price.text = "400";
        buySkin6Button.gameObject.SetActive(true);
        skin6Price.text = "500";

        //***********Reset Trails****************
        buyTrail2Button.gameObject.SetActive(true);
        trail2Price.text = "75";
        buyTrail3Button.gameObject.SetActive(true);
        trail3Price.text = "175";
        buyTrail4Button.gameObject.SetActive(true);
        trail4Price.text = "225";
        buyTrail5Button.gameObject.SetActive(true);
        trail5Price.text = "300";
        buyTrail6Button.gameObject.SetActive(true);
        trail6Price.text = "500";

    }

    /*public void exitShop()
    {
        PlayerPrefs.SetInt("CoinsAmount", gc.coinsAmount);
        //SceneManager.LoadScene("WorldSelect");
    }

    public void goToChallenges()
    {
        PlayerPrefs.SetInt("CoinsAmount", gc.coinsAmount);
        //SceneManager.LoadScene("Challenges");
    }

    */



    /*public void outfitsScreen()
	{
		if (isPaused) {
			Time.timeScale = 0.0f;
			isPaused = !isPaused;
			ui.outfitsScreen.SetActive (true);
			ui.powerupsScreen.SetActive (false);
			ui.coinsScreen.SetActive (false);
		}
	}

	public void powerupsScreen()
	{
		if (!isPaused) {
			Time.timeScale = 0.0f;
			isPaused = !isPaused;
			ui.powerupsScreen.SetActive (true);
			ui.outfitsScreen.SetActive (false);
			ui.coinsScreen.SetActive (false);
		}

	}
	public void coinsScreen()
	{
		if (!isPaused) {
			Time.timeScale = 0.0f;
			isPaused = !isPaused;
			ui.coinsScreen.SetActive (true);
			ui.outfitsScreen.SetActive (false);
			ui.outfitsScreen.SetActive (false);
		}

	}*/
}
