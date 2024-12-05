using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2 : MonoBehaviour

{
    public Ball targetObject;
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
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (targetObject != null)
        {
            // Calculate the direction from the current position to the target position
            Vector3 direction = targetObject.transform.position - transform.position;

            // Normalize the direction vector to get a unit vector
            direction.Normalize();

            // Apply force to the rigidbody in the calculated direction
            GetComponent<Rigidbody2D>().AddForce(direction * MoveSpeed * Time.deltaTime);
        }
    }
}


