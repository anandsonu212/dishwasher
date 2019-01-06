using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;


public class PreviewScenemanager : MonoBehaviour {


	public void changescene(string changeto){

		SceneManager.LoadScene (changeto);

	}
    public void cookingTimerScene()
    {
        Debug.Log("------------------------------CookingNonTimer--------------");
        SceneManager.LoadScene("CookingTimerScene");
        //SceneManager.LoadScene("second");
        
        PlayerPrefs.SetString("Category", "Level1");
        PlayerPrefs.Save();
    }

    public void shoppingTimerScene()
    {
        Debug.Log("------------------------------ShoppingTimer--------------");
        SceneManager.LoadScene("ShoppingTimerScene");
        //SceneManager.LoadScene("second");

        PlayerPrefs.SetString("Category", "Level1");
        PlayerPrefs.Save();
    }

    public void dishwasherTimerScene()
    {
        Debug.Log("------------------------------DishwasherNonTimer--------------");
        SceneManager.LoadScene("DishwashingTimerScene");
        //SceneManager.LoadScene("second");

        PlayerPrefs.SetString("Category", "Level1");
        PlayerPrefs.Save();
    }

    public void cleaningTimerScene()
    {
        Debug.Log("------------------------------CleaningNonTimer--------------");
        SceneManager.LoadScene("CleaningTimerScene");
        //SceneManager.LoadScene("second");

        PlayerPrefs.SetString("Category", "Level1");
        PlayerPrefs.Save();
    }


}
