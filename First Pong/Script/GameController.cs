using UnityEngine;

public class GameController : MonoBehaviour
{

    public int Score1 = 0;
    public int Score2 = 0;
    public int t=0;
    public UIcontroller UIController;
    public GameObject Goal1;
    public GameObject Goal2;
    private Goal Goalfirst;
    private Goal Goalsecond;
    float tempo;
    public AudioController AudioController;
    public Ball Ball;
    public Player Player;
    public Player2 Player2;
    Ball ball;
    public AudioClip Congratulation ;
    public AudioClip Buu ;
    private bool isPlaying = false;
    public bool IsPlaying { get { return isPlaying; } }
    private bool isPaused = false;
    public bool IsPaused { get { return isPaused; } }

    private void Awake()
    {
        Goalfirst = Goal1.GetComponent<Goal>();
        Goalsecond = Goal2.GetComponent<Goal>();
    }
    public void Start()
    {
        Player.transform.position = new Vector3(-8.3f, 0, 0);
        Player2.transform.position = new Vector3(8.3f, 0, 0);
        Ball.transform.position = new Vector3(0, 0, 0);
        UIController.ShowStartPanel();
        UIController.HideGameOver();
        UIController.HideWinner();
        UIController.UpdateScoreText(Score1, Score2);
        UIController.HidePausePanel();
        UIController.HideUnpausePanel();
        UIController.HideGoalPanel();
        PauseGame();
    }
    private void Update()
    {
        Winner();
        if(isPaused && ((Goalfirst.Hits!=0)||(Goalsecond.Hits!=0)) && t==0)
        {
            tempo += Time.unscaledDeltaTime;
            UIController.HidePausePanel();
            UIController.ShowGoalPanel();
            if (tempo >= 3 && ((Goalsecond.Hits != Goalsecond.HIT) || (Goalfirst.Hits != Goalfirst.HIT)))
            {
                UIController.ShowPausePanel();
                UIController.HideGoalPanel();
                UnpausedGame();
                tempo = 0;
            }

        }


    }

    public void AddScore(int _value)

    {
        UIController.UpdateScoreText(Goalsecond.Hits, Goalfirst.Hits);
    }

    public void Resetball()
    {
        Player.transform.position = new Vector3(-8.3f, 0, 0);
        Player2.transform.position = new Vector3(8.3f, 0, 0);
        Ball.transform.position = new Vector3(0, 0, 0);
        Vector3 currentVelocity = Ball.Velocity;
        currentVelocity.y = Mathf.Abs(currentVelocity.y);
        Ball.Velocity = currentVelocity;
        PauseGame2();
        //UnpausedGame();
    }

    public void GameOver()
    {
        UIController.ShowGameOver();
        UIController.HidePausePanel();
        PauseGame();
    }
    public void Winner()
    {
        if (Goalsecond.Hits == 10)
        {
            GameOver();
            UIController.UpdateWinner();
            UIController.ShowWinner();
            AudioController.PlayClip(Congratulation);
        }
        if (Goalfirst.Hits == 10)
        {
            GameOver();
            UIController.UpdateWinner2();
            UIController.ShowWinner();
            AudioController.PlayClip(Buu);
        }


    }
    public void StartGame()
    {
        Player.transform.position = new Vector3(-8.3f, 0, 0);
        Player2.transform.position = new Vector3(8.3f, 0, 0);
        Ball.transform.position = new Vector3(0, 0, 0);
        Goalfirst.Hits = 0;
        Goalsecond.Hits = 0;
        UIController.HideStartPanel();
        isPlaying = true;
        UnpausedGame();
        UIController.ShowPausePanel();
        UIController.HideUnpausePanel();
        UIController.HideGameOver();
        UIController.HideWinner();
        tempo = 0;

    }



    public void PauseGame()
    {
        isPaused = true;
        Time.timeScale = 0;
        t = 1;

    }
    public void PauseGame2()
    {
        isPaused = true;
        Time.timeScale = 0;
        t = 0;

    }
    public void UnpausedGame()
    {
        isPaused = false;
        Time.timeScale = 1;
        t = 0;
    }
    public void OnClick()
    {
        PauseGame();
        UIController.HidePausePanel();
        UIController.ShowUnpausePanel();
    }
    public void OnClick2()
    {
        UnpausedGame();
        UIController.HideUnpausePanel();
        UIController.ShowPausePanel();
    }



    public void QuitGame()
    {
        Player.transform.position = new Vector3(-8.3f, 0, 0);
        Player2.transform.position = new Vector3(8.3f, 0, 0);
        Ball.transform.position = new Vector3(0, 0, 0);
        Goalfirst.Hits = 0;
        Goalsecond.Hits = 0;
        UIController.ShowStartPanel();
        UIController.HideGameOver();
        UIController.HideWinner();
        UIController.UpdateScoreText(Score1, Score2);
        UIController.HidePausePanel();
        UIController.HideUnpausePanel();
        //UIController.OffQuitPanel();
        UIController.HideWinner();
        //UIController.NoWinner();

    }


}
