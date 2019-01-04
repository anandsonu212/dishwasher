﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Text;
using System.IO;

using System.Net;



public class PreviewTaskManager : MonoBehaviour
{

    public static int newhighscore;
    public static int totalquestionstoask = 1;     //Change this value to set how many questions you have to ask in the game.
    [SerializeField]
        private Text showscore;

    [SerializeField]
    private Text counter;

    [SerializeField]
    public float timeforeachquestion;
    private static int correctanswers = 0;
    private static int wronganswers = 0;
    float end = 0;


    /*section 1. This section selects a random question from mcqquestion.cs script along with associated 4 options
    and displays it */

    void Start()
    {
                
    }
   
    void Update()
    {
        if (end == 1)
        {
            return;
        }

        if (end == 0)
        {
            timeforeachquestion = timeforeachquestion - Time.deltaTime;
            counter.text = timeforeachquestion.ToString("F1");
        }

        if (timeforeachquestion < 0.0f)
        {
            //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }

    //sequnce-----> 1)cooking  2)cleaning  3)dishwashing  4)shopping
    public void cookingDone()
    {
        SceneManager.LoadScene("CleaningPreview");
    }
    public void cleaningDone()
    {
        SceneManager.LoadScene("DishwashingPreview");
    }
    public void dishwashingDone()
    {
        SceneManager.LoadScene("ScoreView");
    }
    public void shoppingDone()
    {
        SceneManager.LoadScene("ScoreView");
    }
 
  
    void stopgame()
    {

        end = 1;
        //factText.text = "END OF QUESTIONS";
        int score = correctanswers * 10;
        showscore.text = "Your Score: " + score.ToString();
        //answers.SetTrigger("mcqover");
        System.String description = "I just scored " + correctanswers + " in JFHW Game. CAN YOU BEAT ME?";
        Debug.Log("Stopped game");
        sethighscores();
    }


    void sethighscores()
    {


        //1

        if (PlayerPrefs.GetString("Category") == "mcqGeneral")
        {

            int newhighscore = correctanswers;
            int oldhighscore = PlayerPrefs.GetInt("mcqgkHighScore", 0);

            if (newhighscore > oldhighscore)
            {

                PlayerPrefs.SetInt("mcqgkHighScore", newhighscore);
                PlayerPrefs.Save();

            }
        }

        reset();
    }
    // Reset all variables to initial values

    void reset()
    {

        totalquestionstoask = 10; //change this value to initial value
        correctanswers = 0;
        wronganswers = 0;
       
    }

    public void sharescoreonfb()
    {

            //Application.OpenURL("https://www.facebook.com/dialog/feed?" + "app_id=" + AppID + "&link=" +
            //Link + "&picture=" + Picture + "&name=" + ReplaceSpace(Name) + "&caption=" +
            //ReplaceSpace(Caption) + "&description=" + ReplaceSpace(Description) +
            //"&redirect_uri=https://facebook.com/");
    }

    string ReplaceSpace(string val)
    {
        return val.Replace(" ", "%20");
    }

    public void cancelquiz()
    {

        totalquestionstoask = 10; //change this value to initial value
        correctanswers = 0;
        wronganswers = 0;
         SceneManager.LoadScene("start");


    }
    public void Savecsv(int q_number, int option_selected)
    {
       /* WebClient client = new WebClient();
        client.Credentials = new NetworkCredential("", "");
        byte[] lop = client.UploadFile("http://maxi-xlri.com/play/MCQResponses.csv", "MCQResponses.csv");
        //  byte[] lop = client.UploadFile("C:\\Users\\Sonu Anand\\Documents\\MAXI\\MCQResponses.csv", "/trial");
        Debug.Log(lop);
        Debug.Log("file uploaded");
        string filePath = @".\trial\MCQResponses.csv"; */
        string delimiter = ",";
        string[][] output = new string[][]{
             new string[]{ PlayerPrefs.GetString("User"),PlayerPrefs.GetString("Category"), q_number.ToString(), option_selected.ToString()}
                     };
       // Debug.Log(option_selected.ToString());
       
        int length = output.GetLength(0);
        Debug.Log(length);
        StringBuilder sb = new StringBuilder();
        for (int index = 0; index < length; index++)
            sb.AppendLine(string.Join(delimiter, output[index]));
        string x = sb.ToString();
        Debug.Log(x);
       // StartCoroutine(sendResponsestoCSV(x));
       // SceneManager.LoadScene("Close prompt");
       // File.AppendAllText(filePath, sb.ToString());//
        Debug.Log("Data written blah blah");

        
    }

    IEnumerator sendResponsestoCSV(string sb)
    {
        bool success = true;
        WWWForm form = new WWWForm();
        form.AddField("playerdata", sb);
        Debug.Log(sb);
        WWW send = new WWW("http://localhost/trial/php.php", form);
        yield return send;
        Debug.Log(send.text);
        if (send.error!=null)
        {
            success = false;
            Debug.Log(send.error);
        }
        else
        {
            Debug.Log(send.text);
            success = true;
        }
      
    }

}
