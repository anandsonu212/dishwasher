using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;


public class startscenemanager : MonoBehaviour {


	public void changescene(string changeto){

		SceneManager.LoadScene (changeto);

	}
    public void cookingNonTimer()
    {
        Debug.Log("------------------------------");
        SceneManager.LoadScene("CookingNonTimer");
        PlayerPrefs.SetString("Category", "Level1");
        PlayerPrefs.Save();
        
    }
}
