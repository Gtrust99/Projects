using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
public class GameController : MonoSingleton<GameController>
{
    public GameObject Game;
    public Transform Respawn;
    bool simulatesound;
    public int redo;

    private void Start()
    {

        Game.SetActive(false);
        UIController.Instance.Titlescreen.Play();
        UIController.Instance.ShowStartGame();
        UIController.Instance.ShowCredits();
        UIController.Instance.ShowHowtoPlay();
        UIController.Instance.ShowOptions();
        UIController.Instance.ShowQuit();
        UIController.Instance.HideBack();
        UIController.Instance.HideBack2();
        UIController.Instance.HideBack3();
        UIController.Instance.HideOptionImage();
        UIController.Instance.HideHowToPlayImage();
        UIController.Instance.HideCreditsImage();
        UIController.Instance.HidePlayerUI();
        UIController.Instance.ShowTitle();

        UIController.Instance.HideGameOverScreen();
        UIController.Instance.HideWinScreen();
    }

    private void Update()
    {
        if (Opener.Instance.play)
        {
            UIController.Instance.Level.Play();
        }
    }
    public void StartGame()
    {
        Opener.Instance.transition = 1;
        UIController.Instance.Opening.Play();
        UIController.Instance.Titlescreen.Stop();
        Started();
        //AudioMenuController.Instance.MouseClick.Play();


    }

    public void BackMenu()
    {
        //AudioMenuController.Instance.MouseClick.Play();
        UIController.Instance.Titlescreen.Play();
        UIController.Instance.End.Stop();
        UIController.Instance.Level.Stop();
        UIController.Instance.GameOver.Stop();
        UIController.Instance.Credit.Stop();
        UIController.Instance.Opening.Stop();
        Player.Instance.transform.position = Player.Instance.Favosition.transform.position;
        Opener.Instance.transition = 0;
        Game.SetActive(false);
        UIController.Instance.ShowStartGame();
        UIController.Instance.ShowCredits();
        UIController.Instance.ShowHowtoPlay();
        UIController.Instance.ShowOptions();
        UIController.Instance.HideBack();
        UIController.Instance.HideBack2();
        UIController.Instance.HideBack3();
        UIController.Instance.HideHowToPlayImage();
        UIController.Instance.HideCreditsImage();
        UIController.Instance.HideOptionImage();
        UIController.Instance.HidePlayerUI();
        UIController.Instance.HideGameOverScreen();
        UIController.Instance.HideWinScreen();
        UIController.Instance.ShowTitle();
        UIController.Instance.ShowQuit();
    }

    public void HowToPlayGame()
    {
        UIController.Instance.Titlescreen.Stop();
        //AudioMenuController.Instance.MouseClick.Play();
        UIController.Instance.ShowBack();

        UIController.Instance.ShowHowToPlayImage();
    }

    public void CreditsGame()
    {
        //AudioMenuController.Instance.MouseClick.Play();
        UIController.Instance.Titlescreen.Stop();
        UIController.Instance.Credit.Play();
        UIController.Instance.ShowBack2();
        UIController.Instance.ShowCreditsImage();
    }

    public void OptionsGame()
    {
        //AudioMenuController.Instance.MouseClick.Play();
        UIController.Instance.Titlescreen.Stop();
        UIController.Instance.ShowBack3();
        UIController.Instance.ShowOptionImage();
    }

    public void GameOver()
    {
        Game.SetActive(false);
        //UIController.Instance.HidePlayerUI();
        UIController.Instance.HidePlayerUI();
        Opener.Instance.transition = 0;
        UIController.Instance.Level.Stop();
        UIController.Instance.GameOver.Play();
        UIController.Instance.ShowGameOverScreen();
        Player.Instance.transform.position = Player.Instance.Favosition.transform.position;
        //UIController.Instance.ShowBack3();
        //UIController.Instance.ShowGameOverImage();
    }

    public void EndGame()
    {
        Game.SetActive(false);
        UIController.Instance.ShowWinScreen();
        UIController.Instance.HidePlayerUI();
        UIController.Instance.Level.Stop();
        UIController.Instance.End.Play();
        Player.Instance.transform.position = Player.Instance.Favosition.transform.position;
        Opener.Instance.transition = 0;
        KidSkillController.Instance.KidsCounter = 0;


    }
    public void ResetWithSaves()
    {

        //UIController.Instance.ShowBack3();
        //UIController.Instance.ShowGameOverImage();
        UIController.Instance.HideGameOverScreen();
        UIController.Instance.ShowPlayerUI();
        UIController.Instance.Level.Play();
        UIController.Instance.GameOver.Stop();
        Game.SetActive(true);
        KidSkillController.Instance.KidsCounter = SaveController.Instance.save1;
        OwlShadowController.Instance.transform.localScale = OwlShadowController.Instance.initialScale;
        Player.Instance.transform.position = Player.Instance.Favosition.transform.position;
        //OwlShadowController.Instance.gameObject.SetActive(false);
        UIController.Instance.ShowPlayerUI();
    }


    void Started()
    {

        UIController.Instance.HideStartGame();
        UIController.Instance.HideCredits();
        UIController.Instance.HideHowtoPlay();
        UIController.Instance.HideQuit();
        UIController.Instance.HideOptions();
        UIController.Instance.HideHowToPlayImage();
        UIController.Instance.HideCreditsImage();
        UIController.Instance.HidePlayerUI();
        UIController.Instance.HideTitle();
    }
    public void ResumeGame()
    {
        UIController.Instance.HidepauseScreen();
        Time.timeScale = 1;
    }
    public void QuitGame()
    {
        Application.Quit();
    }
    public void Redo()
    {
        BackMenu();
        KidSkillController.Instance.KidsCounter = 0;
        DamageMeter.Instance.CountingDamage = 0;
        redo = 1;
    }
}
