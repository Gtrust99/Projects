using UnityEngine;

public class GameController : MonoBehaviour
{

    public int Score1 = 0;
    public int Score2 = 0;
    public UIcontroller UIController;
    public GameObject Field;
    public GameObject bolu;
    public Character Character;
    int character;
    public GameObject Goal1;
    public GameObject Goal2;
    private Goal Goalfirst;
    private Goal Goalsecond;
    float tempo;
    ////public AudioController AudioController;
    public Ball Ball;
    public Player Player;
    public Player2 Player2;
    Ball ball;
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
        //UIController.ShowStartPanel();
        UIController.HideGameOver();
        UIController.HideWinner();
        UIController.UpdateScoreText(Score1, Score2);
        UIController.HidePausePanel();
        UIController.HideUnpausePanel();
        //PauseGame();
    }
    private void Update()
    {
        Winner();
        if (isPaused && ((Goalfirst.Hits != 0) || (Goalsecond.Hits != 0)))
        {
            tempo += Time.unscaledDeltaTime;
            Debug.Log(tempo);
            if (tempo >= 5 && ((Goalsecond.Hits != Goalsecond.HIT) || (Goalfirst.Hits != Goalfirst.HIT)))
            {
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
            PauseGame();
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
            if (Goalsecond.Hits == 2)
            {
                GameOver();
                UIController.UpdateWinner();
                UIController.ShowWinner();
            }
            if (Goalfirst.Hits == 2)
            {
                GameOver();
                UIController.UpdateWinner2();
                UIController.ShowWinner();
            }


          }
            public void StartGame()
             {
                Field.SetActive(true);
                //Character.StartCaracter();
                //Character.StartCharacter2();
                Player.transform.position = new Vector3(-10f, 0, 0);
                Player2.transform.position = new Vector3(10f, 0, 0);
                bolu.SetActive(true);
                Ball.transform.position = new Vector3(3, 0.5f, 0);
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
                //UIController.NoWinner();
            }
        public void PauseGame()
        {
        isPaused = true;
        Time.timeScale = 0;



        ////        if (isPlaying)
        ////        {
        ////            UIController.ShowPausePanel();
        ////        }
    }
        public void UnpausedGame()
        {
            isPaused = false;
            Time.timeScale = 1;
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

        public void CharacterClick()
    {
        UIController.ShowP1Panel();
        UIController.ShowP2Panel();
        UIController.HideShowCharacterPanel();
        UIController.HideOptionpanel();

    }
    public void P1choose()
    {
        UIController.HideP1Panel();
        UIController.HideP2Panel();
        UIController.OnQuitPanel();
        //Character.choosingcharacter1=1;
         
    }
    public void P2choose()
    {
        UIController.HideP1Panel();
        UIController.HideP2Panel();
        UIController.OnQuitPanel();
        //Character.choosingcharacter2= 1;

    }


    public void Options()
    {
        UIController.HideOptionpanel();
        UIController.ShowDifficultPanel();
        UIController.ShowEffectpanel();
        UIController.ShowMusicPanel();
        UIController.OnQuitPanel();
        UIController.HideShowCharacterPanel();
    }
    public void Easy()
    {
        //Player2.MoveSpeed = 10;
    }
    public void Medium()
    {
        //Player2.MoveSpeed = 100;
    }
    public void Hard()
    {
        //Player2.MoveSpeed = 1000;
    }
    public void TryQuit()
    {
        UIController.ShowOptionpanel();
        UIController.ShowShowCharacterPanel();
        UIController.OffQuitPanel();
        UIController.HideDifficultPanel();
        UIController.HideEffectPanel();
        UIController.HideMusicpanel();
        UIController.HideP1Panel();
        UIController.HideP2Panel();

    }
}
    //public void QuitGame()
    //{
    //    Player.transform.position = new Vector3(-8.3f, 0, 0);
    //    Player2.transform.position = new Vector3(8.3f, 0, 0);
    //    Ball.transform.position = new Vector3(0, 0, 0);
    //    Goalfirst.Hits = 0;
    //    Goalsecond.Hits = 0;
    //    UIController.ShowStartPanel();
    //    UIController.HideGameOver();
    //    UIController.HideWinner();
    //    UIController.UpdateScoreText(Score1, Score2);
    //    UIController.HidePausePanel();
    //    UIController.HideUnpausePanel();
    //    //UIController.OffQuitPanel();
    //    UIController.HideWinner();
    //    //UIController.NoWinner();

    //}

    //private IEnumerator Start()
    //{
    //    Debug.Log("Before delay");

    //    // Put a delay of 2 seconds here
    //    yield return new WaitForSeconds(5f);

    //    Debug.Log("After delay");
    


