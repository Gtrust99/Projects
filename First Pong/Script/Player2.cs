using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2 : MonoBehaviour

{
    public Ball Ball;
    public float MoveSpeed;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Ball != null)
        {
          
            Vector3 direction = Ball.transform.position - transform.position;

            
            direction.Normalize();

            
            GetComponent<Rigidbody2D>().AddForce(direction * MoveSpeed*Time.deltaTime);

        }
    }
}


