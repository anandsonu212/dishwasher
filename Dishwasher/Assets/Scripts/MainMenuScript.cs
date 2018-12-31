using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenuScript : MonoBehaviour {

	// Load Scene 01 when start button is pressed
	public void StartGame()
	{
        InputField inputField;
        inputField = GameObject.Find("UserIDInputField").GetComponent<InputField>();

        if ( inputField.text == "") {
            SSTools.ShowMessage("Please Enter User ID", SSTools.Position.top, SSTools.Time.twoSecond);
        }
        else
        {
            SceneManager.LoadScene("Scene1");
        }
	}

	// Reset All Player Preferences data to start earn trophies again
	public void ResetPlayerPrefs()
	{
		PlayerPrefs.DeleteAll ();
	}

}
