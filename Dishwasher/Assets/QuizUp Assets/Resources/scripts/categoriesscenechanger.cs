using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class categoriesscenechanger : MonoBehaviour {

	/////////////////////TF Categories ///////////////////////////////////	


	public void tfgeneral(){

		PlayerPrefs.SetString ("Category", "tfGeneral");
		PlayerPrefs.Save ();
		SceneManager.LoadScene ("timerscene");
	
	}

	public void tfmovies(){

		PlayerPrefs.SetString ("Category", "tfMovies");
		PlayerPrefs.Save ();
		SceneManager.LoadScene("timerscene");

	}

	public void tfcaleb(){

		SceneManager.LoadScene("timerscene");
		PlayerPrefs.SetString ("Category", "tfCaleb");
		PlayerPrefs.Save ();

	}

	public void tfsports(){

		SceneManager.LoadScene("timerscene");
		PlayerPrefs.SetString ("Category", "tfSports");
		PlayerPrefs.Save ();

	}

	public void tfgames(){

		SceneManager.LoadScene("timerscene");
		PlayerPrefs.SetString ("Category", "tfGames");
		PlayerPrefs.Save ();

	}

	public void tfnature(){

		SceneManager.LoadScene("timerscene");
		PlayerPrefs.SetString ("Category", "tfNature");
		PlayerPrefs.Save ();

	}

	public void tfgeography(){

		SceneManager.LoadScene("timerscene");
		PlayerPrefs.SetString ("Category", "tfGeography");
		PlayerPrefs.Save ();

	}

	public void tfhistory(){

		SceneManager.LoadScene("timerscene");
		PlayerPrefs.SetString ("Category", "tfHistory");
		PlayerPrefs.Save ();

	}


	public void tflifestlye(){

		SceneManager.LoadScene("timerscene");
		PlayerPrefs.SetString ("Category", "tfLifestyle");
		PlayerPrefs.Save ();

	}


	// MCQ Categories //////////////////////////////////////////////////////////////////////////// 

	public void LevelFive(){

		SceneManager.LoadScene("timerscene");
		PlayerPrefs.SetString ("Category", "Level5");
		PlayerPrefs.Save ();

	}

	public void LevelOne(){

		SceneManager.LoadScene("timerscene");
		PlayerPrefs.SetString ("Category", "Level1");
		PlayerPrefs.Save ();

	}

	public void LevelFour(){

		SceneManager.LoadScene("timerscene");
		PlayerPrefs.SetString ("Category", "Level4");
		PlayerPrefs.Save ();

	}

	

	public void LevelThree(){

		SceneManager.LoadScene("timerscene");
		PlayerPrefs.SetString ("Category", "Level3");
		PlayerPrefs.Save ();

	}

	

	public void LevelTwo(){

		SceneManager.LoadScene("timerscene");
		PlayerPrefs.SetString ("Category", "Level2");
		PlayerPrefs.Save ();

	}
		

	public void mcqrandom(){

		int randomindex = Random.Range (1,10);

		if (randomindex == 1)
			LevelFive ();
		
		else if (randomindex == 2)
			LevelFour ();

		else if (randomindex == 3)
			LevelOne ();

		else if (randomindex == 4)
			LevelThree ();

		else if (randomindex == 5)
			LevelTwo ();

			}


	public void tfrandom(){

		int randomindex = Random.Range (1,10);

		if (randomindex == 1)
			tfgeneral ();

		else if (randomindex == 2)
			tfcaleb ();

		else if (randomindex == 3)
			tfsports ();

		else if (randomindex == 4)
			tfgames ();

		else if (randomindex == 5)
			tfnature ();

		else if (randomindex == 6)
			tfgeneral ();

		else if (randomindex == 7)
			tfhistory ();

		else if (randomindex == 8)
			tflifestlye ();

		else if (randomindex == 9)
			tfcaleb ();
	}
}
