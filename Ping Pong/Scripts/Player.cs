using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update

    public float MoveSpeed;
    public GameObject zero;
    public GameObject one;
    public GameObject two;
    public GameObject three;
    public GameObject four;
    public GameObject Model0;
    public GameObject Model1;
    public GameObject Model2;
    public GameObject Model3;
    public GameObject Model4;

    //GameController gameController;
    private void Awake()
    {
        //gameController = FindObjectOfType<GameController>();
  

    }

    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(Vector2.up * MoveSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(Vector2.down * MoveSpeed * Time.deltaTime);
        }
        //float moveX = Input.GetAxis("Horizontal");
        //float moveY = Input.GetAxis("Vertical");

        //Vector3 move = new Vector3(moveX, moveY, 0) * MoveSpeed;
        //transform.position += move * Time.deltaTime;
         
    }


}
