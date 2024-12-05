using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{
    public int Hits = 0;
    public int HIT = 0;
    public int ScoreValue = 1;
    GameController gameController;
    public AudioClip OnBreakAudio;

    private void Awake()
    {
        gameController = FindObjectOfType<GameController>();
    }
    public void OnHit()
    {

        

        if (Hits >= 0 && Hits <= 11)
        {   
            
            Hits++;
            HIT =Hits-1;
            
        }
        gameController.AddScore(Hits);
    }
    
    
}

