using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;


public class startscenemanager : MonoBehaviour {


	public void changescene(string changeto){

		SceneManager.LoadScene (changeto);
    }

    public void Start()
    {   

    }

    public void cookingNonTimer()
    {
        Debug.Log("------------------------------asdsadsdsdsddas");
        SceneManager.LoadScene("CookingNonTimer");
        PlayerPrefs.SetString("Category", "Level1");
        PlayerPrefs.Save();
    }

    public void cookingTask()
    {
        Debug.Log("------------------------------asfgdgdggddfggd");
        SceneManager.LoadScene("cookingTask");
        PlayerPrefs.SetString("Category", "Level1");
        PlayerPrefs.Save();
    }
    
    public void cooking()
    {
        SceneManager.LoadScene("cookingPreview");
        PlayerPrefs.SetInt("totalscore", 0);
        PlayerPrefs.SetInt("cookingscore", 0);
        PlayerPrefs.SetInt("cleaningscore", 0);
        PlayerPrefs.SetInt("dishwashscore", 0);
        PlayerPrefs.Save();
    }

    public void secondScene()
    {
        Debug.Log("------------------------------777777777777777");
        SceneManager.LoadScene("second");
        PlayerPrefs.Save();

    }
}
