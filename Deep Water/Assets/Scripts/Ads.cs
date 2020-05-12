using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Advertisements;

public class Ads : MonoBehaviour 
{
	//ShopControl sc; 
	string gameIdentification = "1234567";
	bool testMode = true;

	void Start () {
		//rb = GetComponent<Rigidbody2D> ();
		//sc = GetComponent<ShopControl> ();
		Advertisement.Initialize (gameIdentification, testMode);
	}

	/*public void ShowRewardedAd()
	{
		if (Advertisement.IsReady())
		{
			//var options = new ShowOptions { resultCallback = HandleShowResult };
			Advertisement.Show();
		}

		ShowOptions options = new ShowOptions ();
		options.resultCallback = HandleShowResult;

		Advertisement.Show ("rewardedVideo", options);
	}*/

	/*private void HandleShowResult(ShowResult result)
	{
		switch (result)
		{
		case ShowResult.Finished:
			Debug.Log("The ad was successfully shown.");
			//
			// YOUR CODE TO REWARD THE GAMER
			// Give coins etc.
			break;
		case ShowResult.Skipped:
			Debug.Log("The ad was skipped before reaching the end.");
			break;
		case ShowResult.Failed:
			Debug.LogError("The ad failed to be shown.");
			break;
		}

		if (result == ShowResult.Finished)
		{
			//Add code to reward your player here!
			//Give coins, etc
			sc.coinsAmount += 200;
		}
	}*/

}
