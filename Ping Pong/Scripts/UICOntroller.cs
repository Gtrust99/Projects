using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIcontroller : MonoBehaviour
{
    public Text ScoreText;
    public Text WinnerText;
    public string Player;
    public string Player2;
    public GameObject StartPanel;
    public GameObject GameOverPanel;
    public GameObject PausePanel;
    public GameObject UnPausePanel;
    public GameObject Winnerpanel;
    public GameObject Selectpanel;
    public GameObject P1panel;
    public GameObject P2panel;
    public GameObject OptionPanel;
    public GameObject Music;
    public GameObject Effect;
    public GameObject Difficult;
    public GameObject Quitpanel;
    // Start is called before the first frame update
    void Start()
    {

    }

    //// Update is called once per frame
    //void Update()
    //{

    //}
    public void UpdateScoreText(int _value, int value)
    {
        ScoreText.text = _value.ToString() + ":" + value.ToString();
    }
    public void UpdateWinner()
    {
        WinnerText.text = "Congrats " + Player + " Obviuosly you lose " + Player2;
    }
    public void UpdateWinner2()
    {
        WinnerText.text = "Congrats " + Player2 + " Obviuosly you lose " + Player;
    }
    public void NoWinner()
    {
        WinnerText.text = " ";
    }
    public void ShowGameOver()
    {
        GameOverPanel.SetActive(true);
    }
    public void HideGameOver()
    {
        GameOverPanel.SetActive(false);
    }
    public void ShowWinner()
    {
        Winnerpanel.SetActive(true);
    }
    public void HideWinner()
    {
        Winnerpanel.SetActive(false);
    }
    public void ShowPausePanel()
    {
        PausePanel.SetActive(true);
    }
    public void HidePausePanel()
    {
        PausePanel.SetActive(false);
    }
    public void ShowUnpausePanel()
    {
        UnPausePanel.SetActive(true);
    }
    public void HideUnpausePanel()
    {
        UnPausePanel.SetActive(false);
    }
    public void ShowStartPanel()
    {
        StartPanel.SetActive(true);
    }
    public void HideStartPanel()
    {
        StartPanel.SetActive(false);
    }
    public void ShowShowCharacterPanel()
    {
        Selectpanel.SetActive(true);
    }
    public void HideShowCharacterPanel()
    {
        Selectpanel.SetActive(false);
    }
    public void ShowP1Panel()
    {
        P1panel.SetActive(true);
    }
    public void HideP1Panel()
    {
        P1panel.SetActive(false);
    }
    public void ShowP2Panel()
    {
        P2panel.SetActive(true);
    }
    public void HideP2Panel()
    {
        P2panel.SetActive(false);
    }
    public void ShowOptionpanel()
    {
        OptionPanel.SetActive(true);
    }
    public void HideOptionpanel()
    {
        OptionPanel.SetActive(false);
    }
    public void ShowDifficultPanel()
    {
        Difficult.SetActive(true);
    }
    public void HideDifficultPanel()
    {
        Difficult.SetActive(false);
    }
    public void ShowEffectpanel()
    {
        Effect.SetActive(true);
    }
    public void HideEffectPanel()
    {
        Effect.SetActive(false);
    }
    public void ShowMusicPanel()
    {
        Music.SetActive(true);
    }
    public void HideMusicpanel()
    {
        Music.SetActive(false);
    }
    public void OnQuitPanel()
    {
        Quitpanel.SetActive(true);
    }
    public void OffQuitPanel()
    {
        Quitpanel.SetActive(false);
    }
}
