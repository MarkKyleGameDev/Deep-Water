using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Advertisements;

[RequireComponent(typeof(Button))]
public class UnityAdsButton: MonoBehaviour
{
	//ShopControl sc; 
	Button m_Button;

	public string placementId = "rewardedVideo";
	//public string placementId = "1e78c4f8-1a84-445b-9737-bb330faee0d5";

	void Start()
	{
		//sc = GetComponent<ShopControl> ();
		m_Button = GetComponent<Button> ();
		if (m_Button)
			m_Button.onClick.AddListener (ShowAd);
	}

	void Update()
	{
		if (m_Button)
			m_Button.interactable = Advertisement.IsReady(placementId);	
	}

	public void ShowAd()
	{
		ShowOptions options = new ShowOptions ();
		options.resultCallback = HandleShowResult;

		Advertisement.Show (placementId, options);
	}

	public void HandleShowResult (ShowResult result)
	{
		if (result == ShowResult.Finished) 
		{
			Debug.Log ("The ad was successfully shown.");
		} 
		else if (result == ShowResult.Skipped) 
		{
			Debug.LogWarning ("The ad was skipped before reaching the end.");
		} 
		else if (result == ShowResult.Failed) 
		{
			Debug.LogError("The ad failed to be shown.");
		}
	}
}