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

        

        if (Hits >= 0 && Hits <= 9)
        {   
            
            Hits++;
            HIT =Hits-1;
            
        }
        gameController.AddScore(Hits);
    }
    
    //public void OnHit1(int _value)
    //{
    //    Hits1++;
    //    _value++;

    //    //if (Hits1 >= 0 && Hits1 <= 10)
    //    //{
    //    //    gameController.AddScore(_value,Hits2);
    //    //}
    //}
    //public void OnHit2(int value)
    //{
    //    Hits2++;
    //    value++;

    //    //if (Hits2 >= 0 && Hits2<= 10)
    //    //{
    //    //    gameController.AddScore(Hits1,value);
    //    //}
    //}
    // private void Update()
    //{
    //float HorizontalMove = Mathf.PingPong(Time.time * playSpeed, pingDistance);
    //Vector3 newPosition= new Vector3(HorizontalMove,transform.position.y-MoveSpeed*Time.deltaTime,0);
    //transform.position=newPosition;
    // }
}

