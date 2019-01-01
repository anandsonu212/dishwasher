using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;


public class startscenemanager : MonoBehaviour {


	public void changescene(string changeto){

		SceneManager.LoadScene (changeto);

	}
    public void cookingNonTimer()
    {
        Debug.Log("------------------------------asdsadsdsdsddas");
        SceneManager.LoadScene("CookingNonTimer");
        //SceneManager.LoadScene("second");
        
        PlayerPrefs.SetString("Category", "Level1");
        PlayerPrefs.Save();
    }

    public void cookingTask()
    {
        Debug.Log("------------------------------asfgdgdggddfggd");
        SceneManager.LoadScene("cookingTask");
        //SceneManager.LoadScene("second");

        PlayerPrefs.SetString("Category", "Level1");
        PlayerPrefs.Save();
    }



    public void cooking()
    {
        Debug.Log("------------------------------ooooooooooooooooo");
        SceneManager.LoadScene("cookingPreview");
        //SceneManager.LoadScene("second");

        PlayerPrefs.SetString("Category", "Level1");
        PlayerPrefs.Save();
    }

    public void secondScene()
    {
        Debug.Log("------------------------------777777777777777");
     //   SceneManager.LoadScene("CookingNonTimer");
        SceneManager.LoadScene("second");

        PlayerPrefs.SetString("Category", "Level1");
        PlayerPrefs.Save();

    }
}
