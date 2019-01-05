using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ScoreViewScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int totalscore = PlayerPrefs.GetInt("totalscore", 0);
        Text text = GameObject.Find("scoreText").GetComponent<Text>();
        text.text = "You Scored " +  totalscore.ToString() ;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
