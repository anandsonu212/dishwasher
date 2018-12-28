using UnityEngine;
using System.Collections;

public class rateus : MonoBehaviour {

	public GameObject rateuspanel;

	private string alreadyrated;


	// Use this for initialization
	void Start () {
	

		alreadyrated = PlayerPrefs.GetString ("alreadyrated");

		if (alreadyrated == "no" || alreadyrated == "")
			rateuspanel.SetActive (true);
		
		if (alreadyrated == "yes" )
			rateuspanel.SetActive (false);
	}
	
	public void rate(){

		Application.OpenURL("https://play.google.com/store/apps/details?id=com.digiart.correctside");
		rateuspanel.SetActive (false);
		PlayerPrefs.SetString ("alreadyrated", "yes");
		PlayerPrefs.Save ();
	}

	public void nothanks(){

		rateuspanel.SetActive (false);
		PlayerPrefs.SetString ("alreadyrated", "no");
		PlayerPrefs.Save ();
	}
}
