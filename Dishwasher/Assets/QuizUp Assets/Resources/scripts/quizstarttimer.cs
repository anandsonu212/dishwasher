using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class quizstarttimer : MonoBehaviour {

	[SerializeField]
	private Text timer;


	void Start(){
		StartCoroutine (delay ());
	}


	IEnumerator delay(){
		timer.text = "3";

		yield return new WaitForSeconds (1);
		timer.text = "2";

		yield return new WaitForSeconds (1);
		timer.text = "1";

		yield return new WaitForSeconds (1);
		timer.text = "GO !";

		startquiz ();

	}
	void startquiz(){

		if (PlayerPrefs.GetString ("Category") == "tfGeneral") {
		
			SceneManager.LoadScene ("tf gk");
		}

		if (PlayerPrefs.GetString ("Category") == "tfMovies") {

			SceneManager.LoadScene ("tf movies");
		}

		if (PlayerPrefs.GetString ("Category") == "tfCaleb") {

			SceneManager.LoadScene ("tf caleb");
		}

		if (PlayerPrefs.GetString ("Category") == "tfSports") {

			SceneManager.LoadScene ("tf sports");
		}

		if (PlayerPrefs.GetString ("Category") == "tfGames") {

			SceneManager.LoadScene ("tf games");
		}

		if (PlayerPrefs.GetString ("Category") == "tfNature") {

			SceneManager.LoadScene ("tf nature");
		}

		if (PlayerPrefs.GetString ("Category") == "tfGeography") {

			SceneManager.LoadScene ("tf geography");
		}

		if (PlayerPrefs.GetString ("Category") == "tfHistory") {

			SceneManager.LoadScene ("tf history");
		}

		if (PlayerPrefs.GetString ("Category") == "tfLifestyle") {

			SceneManager.LoadScene ("tf lifestyle");
		}


		//MCQS 

		if (PlayerPrefs.GetString ("Category") == "Level1") {

			SceneManager.LoadScene ("LevelOne");
		}

		if (PlayerPrefs.GetString ("Category") == "Level2") {

			SceneManager.LoadScene ("LevelTwo");
		}

		if (PlayerPrefs.GetString ("Category") == "Level3") {

			SceneManager.LoadScene ("LevelThree");
		}

		if (PlayerPrefs.GetString ("Category") == "Level4") {

			SceneManager.LoadScene ("LevelFour");
		}

		if (PlayerPrefs.GetString ("Category") == "Level5") {

			SceneManager.LoadScene ("LevelFive");
		}

		

	}
}
