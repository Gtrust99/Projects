using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoSingleton<UIController>
{

    public GameObject Startgame;
    public GameObject Credits;
    public GameObject Options;
    public GameObject HowToPlay;
    public GameObject Back;
    public GameObject Back2;
    public GameObject Back3;
    public GameObject HowToPlayScreen;
    public GameObject CreditScreen;
    public GameObject PlayerUI;
    public GameObject OptionScreen;
    public GameObject GameOverScreen;
    public GameObject WinScreen;
    public GameObject Title;
    public AudioSource Titlescreen;
    public AudioSource Opening;
    public AudioSource Level;
    public AudioSource End;
    public AudioSource Credit;
    public AudioSource GameOver;
    public GameObject PauseScreen;
    public GameObject Quit;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
    
        //Startgame = GameObject.Find("Start");
        //Credits = GameObject.Find("Credits");
        //Options = GameObject.Find("Options");
        //HowToPlay = GameObject.Find("HowToPlay");
    
    }
    // Update is called once per frame
    public void ShowStartGame()
    {
        Startgame.SetActive(true);
    }
    public void HideStartGame()
    {
        Startgame.SetActive(false);
    }
    public void ShowCredits()
    {
        Credits.SetActive(true);
    }
    public void HideCredits()
    {
        Credits.SetActive(false);
    }
    public void ShowHowtoPlay()
    {
        HowToPlay.SetActive(true);
    }
    public void HideHowtoPlay()
    {
        HowToPlay.SetActive(false);
    }
     public void ShowOptions()
    {
        Options.SetActive(true);
    }
    public void HideOptions()
    {
        Options.SetActive(false);
    }
    public void ShowBack()
    {
        Back.SetActive(true);
    }
    public void HideBack()
    {
        Back.SetActive(false);
    }
    public void ShowBack2()
    {
        Back2.SetActive(true);
    }
    public void HideBack2()
    {
        Back2.SetActive(false);
    }
    public void ShowBack3()
    {
        Back3.SetActive(true);
    }
    public void HideBack3()
    {
        Back3.SetActive(false);
    }
    public void ShowHowToPlayImage()
    {
        HowToPlayScreen.SetActive(true);
    }
    public void HideHowToPlayImage()
    {
        HowToPlayScreen.SetActive(false);
    }
    public void ShowCreditsImage()
    {
        CreditScreen.SetActive(true);
    }
    public void HideCreditsImage()
    {
        CreditScreen.SetActive(false);
    }
    public void ShowOptionImage()
    {
        OptionScreen.SetActive(true);
    }
    public void HideOptionImage()
    {
        OptionScreen.SetActive(false);
    }
    public void ShowPlayerUI()
    {
        PlayerUI.SetActive(true);
    }
    public void HidePlayerUI()
    {
        PlayerUI.SetActive(false);
    }
    public void ShowTitle()
    {
        Title.SetActive(true);
    }
    public void HideTitle()
    {
        Title.SetActive(false);
    }
    public void ShowGameOverScreen()
    {
        GameOverScreen.SetActive(true);
    }
    public void HideGameOverScreen()
    {
        GameOverScreen.SetActive(false);
    }
    public void ShowWinScreen()
    {
        WinScreen.SetActive(true);
    }
    public void HideWinScreen()
    {
        WinScreen.SetActive(false);
    }
    public void ShowPauseScreen()
    {
        PauseScreen.SetActive(true);
    }
    public void HidepauseScreen()
    {
        PauseScreen.SetActive(false);
    }
    public void ShowQuit()
    {
        Quit.SetActive(true);
    }
    public void HideQuit()
    {
        Quit.SetActive(false);
    }

}