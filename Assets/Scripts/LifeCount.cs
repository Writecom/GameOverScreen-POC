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
        
        /* Loader forskellige GameObjects i vores scene så de kan bruges.
         * 
         * BRUGES IKKE, DA DET ER BEDRE OG NEMMERE, AT DRAG AND DROP INDE I UNITY.
         * 
         * Det kan vi gøre, da vi har sat en public GameObject variable
         * Så kommer vores variable frem i Inspector, hvor vi kan drag and drop 
         * det GameObject vi ønsker skal være værdien for vores variable
         * 
        gameOverScreen = GameObject.Find("gameOverScreen");
        GamePlayingScreen = GameObject.Find("GamePlayingScreen");
        */

    }
    // Update is called once per frame
    void Update()
    {
        //Værdien af LifeCount, opdateres hele tiden, så når værdien falder, vises det også i display
        life.text = lifeAmount.ToString();

        //Spillet tjekker konstant vores if-statement, om vores LifeCount er lig 0
        gameOver();
    }

    //Bruges til vores knap, der fjerne fra vores lifeAmount
    public void removeLife()
    {
        lifeAmount -= lifeDecrease;
    }
    
    //Vores method der kører oppe i Update
    //Er vores lifeAmount lig 0, deaktiverer vi vores GamePlayingScreen
    //og aktiverer vores gameOverScreen
    public void gameOver()
     {
            if (lifeAmount == death)
            {
                 //sætter gameoverscreen til
                gameOverScreen.SetActive(true);

                //Deaktiverer vores GamePlayingScreen
                GamePlayingScreen.SetActive(false);
            }
           
        }

    //Kodereference fra https://youtu.be/XtQMytORBmM?si=tqS8EyRgqJh_4k-c&t=2334
    //Sættes på vores restart knap. Når den reloader scene, starter alt forfra
    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
