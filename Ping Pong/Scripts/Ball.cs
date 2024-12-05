using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{

    GameObject lastObjectHit;
    CircleCollider2D circleCollider;
    GameController gameController;
    public Vector2 Velocity = new Vector2(10, 10);
    public AudioClip OnWallHitAudio;
    public AudioClip OnPedalHitAudio;

    private void Awake()
    {
        circleCollider = GetComponent<CircleCollider2D>();
        gameController = FindObjectOfType<GameController>();

    }
    // Update is called once per frame
    void Update()
    {
        transform.Translate(Velocity * Time.deltaTime);
        RaycastHit2D[] hits = Physics2D.CircleCastAll(transform.position, circleCollider.radius, Velocity, (Velocity * Time.deltaTime).magnitude);
        foreach (RaycastHit2D hit in hits)
            if (hit.collider != circleCollider && hit.transform.gameObject != lastObjectHit)
            {

                lastObjectHit = hit.transform.gameObject;

                Velocity = Vector2.Reflect(Velocity, hit.normal);

                if (hit.transform.GetComponent<Player>() || hit.transform.GetComponent<Player2>())
                {
                    Velocity.y = Velocity.y + 0.15f;  //Mathf.Abs(Velocity.y)
                    Velocity.x = Velocity.x + 0.15f;
                    //Velocity += Velocity;
                    //gameController.AudioController.PlayClip(OnPedalHitAudio);
                }
                if (hit.transform.GetComponent<Goal>())
                {
                    hit.transform.GetComponent<Goal>().OnHit();
                    //Velocity.x = Random.Range(-10, 10);
                    //Velocity.y = Random.Range(-10, 10);
                    gameController.Resetball();
                    //StartCoroutine(PauseGameTime(5f));

                }
                if (hit.transform.GetComponent<Padel>())
                {
                    Velocity.y = 3;  //Mathf.Abs(Velocity.y)
                    Velocity.x = 0;
                    Velocity += Velocity;
                    //gameController.AudioController.PlayClip(OnPedalHitAudio);
                }

                //gameController.AudioController.PlayClip(OnWallHitAudio);
            }
    }
}
    //public IEnumerator PauseGameTime(float delayTime)
    //{
    //    Debug.Log("IN");
    //    yield return new WaitForSeconds(delayTime);
    //    // Execute the desired code after the delay
    //    Debug.Log("This message will appear after a delay of " + delayTime + " seconds.");
    //    gameController.Resetball();
    //}
    //private IEnumerator Start()
    //{
    //    Debug.Log("Before delay");

    //    // Put a delay of 2 seconds here
    //    yield return new WaitForSeconds(5f);

    //    Debug.Log("After delay");
    //}




