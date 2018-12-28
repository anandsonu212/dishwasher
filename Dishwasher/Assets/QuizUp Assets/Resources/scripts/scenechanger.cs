using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;


public class scenechanger : MonoBehaviour {


	public string previousscene;

	public void changescene(string changeto){

		SceneManager.LoadScene (changeto);

	}

    public void LevelTwo()
    {

        SceneManager.LoadScene("timerscene");
        PlayerPrefs.SetString("Category", "Level2");
        PlayerPrefs.Save();

    }

    void Update (){
	

			if (Input.GetKey (KeyCode.Escape) || Input.GetKey (KeyCode.A)) {
	
			SceneManager.LoadScene (previousscene);
			}
			


}
}
