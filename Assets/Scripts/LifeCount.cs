using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class LifeCount : MonoBehaviour
{

    public TMP_Text life;

    public int lifeAmount = 30;

    public int lifeDecrease = 10;

    private int death = 0;

    public GameObject gameOverScreen;
    public GameObject GamePlayingScreen;

    // Start is called before the first frame update
    void Start()
    {
        
        /* Loader forskellige GameObjects i vores scene s� de kan bruges.
         * 
         * BRUGES IKKE, DA DET ER BEDRE OG NEMMERE, AT DRAG AND DROP INDE I UNITY.
         * 
         * Det kan vi g�re, da vi har sat en public GameObject variable
         * S� kommer vores variable frem i Inspector, hvor vi kan drag and drop 
         * det GameObject vi �nsker skal v�re v�rdien for vores variable
         * 
        gameOverScreen = GameObject.Find("gameOverScreen");
        GamePlayingScreen = GameObject.Find("GamePlayingScreen");
        */

    }
    // Update is called once per frame
    void Update()
    {
        //V�rdien af LifeCount, opdateres hele tiden, s� n�r v�rdien falder, vises det ogs� i display
        life.text = lifeAmount.ToString();

        //Spillet tjekker konstant vores if-statement, om vores LifeCount er lig 0
        gameOver();
    }

    //Bruges til vores knap, der fjerne fra vores lifeAmount
    public void removeLife()
    {
        lifeAmount -= lifeDecrease;
    }
    
    //Vores method der k�rer oppe i Update
    //Er vores lifeAmount lig 0, deaktiverer vi vores GamePlayingScreen
    //og aktiverer vores gameOverScreen
    public void gameOver()
     {
            if (lifeAmount == death)
            {
                 //s�tter gameoverscreen til
                gameOverScreen.SetActive(true);

                //Deaktiverer vores GamePlayingScreen
                GamePlayingScreen.SetActive(false);
            }
           
        }

    //Kodereference fra https://youtu.be/XtQMytORBmM?si=tqS8EyRgqJh_4k-c&t=2334
    //S�ttes p� vores restart knap. N�r den reloader scene, starter alt forfra
    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
