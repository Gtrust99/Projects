using UnityEngine;
using System.Collections;
public class Player : MonoSingleton<Player>
{
    public AudioSource audioSource;
    public AudioSource audioSource1;
    public float speed = 5f; // Velocit� di movimento
    bool need;
    bool fakingdeath = false;
    public bool fakingdeathbutton = false;
    bool scream = false;
    bool jumped = false;
    public bool screambutton = false;
    public bool CanMove = true;
    public float forzaSalto = 5f;
    private Rigidbody rb;
    public GameObject Favosition;
    public Transform puntoRaggio; // Punto da cui fare il raycast
    public float distanzaRaggio = 0.1f; // Distanza del raycast
    public LayerMask layerTerra; // Layer del terreno
    private bool aTerra;
    public int sx;
    public GameObject Owl;
    public float altezzaSalto = 2f; // altezza del salto
    private float velocitaVerticale = 0f;
    public bool cambio;
    private void Start()
    {
        cambio = false;

        //GetComponent<Renderer>().material.color = Color.blue;



        rb = GetComponent<Rigidbody>();



    }
    void ChangeDirection( Vector3 movement)
    {
        movement = -movement;
    }

    void Update()
    {
        Vector3 movement = Vector3.zero;
        if (!Input.anyKey && !fakingdeathbutton && !screambutton)
        {
            sx = 0;
            AnimationController.Instance.animator.SetInteger("SX", 0);
        }
        if (Rock.Instance.unlock)
        {
            ColliderController.Instance.ActivateColliders();
        }

        if (!Rock.Instance.unlock)
        {
            ColliderController.Instance.DeactivateColliders();
        }
        if (transform.position.y <= 0.77)
        {
            rb.constraints = RigidbodyConstraints.FreezePositionY | RigidbodyConstraints.FreezeRotationY;
            rb.constraints = RigidbodyConstraints.None;
            rb.useGravity = false;
        }

        if (transform.position.y >= 2)
        {
            rb.useGravity = true;
        }

        //if (transform.position.y>= 1.5)
        //{
        //    transform.position=new Vector3 (transform.position.x,0.77f,transform.position.z);
        //}


        aTerra = Physics.CheckSphere(puntoRaggio.position, distanzaRaggio, layerTerra);

        //{
        //    aTerra = true;
        //}
        //else
        //{
        //    aTerra = false;
        //}
        if (Input.GetKey(KeyCode.W) && CanMove == true)
        {
            AnimationController.Instance.IdleMotion();
            //AnimationController.Instance.animator.enabled = true;
            movement += Vector3.back;
            if (jumped)
            {
                audioSource1.Stop();
            }
            else
            {
                audioSource1.Play();
            }
            sx = 1;




        }
        if (Input.GetKey(KeyCode.S) && CanMove == true)
        {
            //    AnimationController.Instance.animator.enabled = true;
            //AnimationController.Instance.IdleMotion();
            movement += Vector3.forward;
            if (jumped)
            {
                audioSource1.Stop();
            }
            else
            {
                audioSource1.Play();
            }
            //transform.eulerAngles = new Vector3(transform.eulerAngles.x, 180, transform.eulerAngles.z);
            //sx = 1;
        }
        if (Input.GetKey(KeyCode.A) && CanMove == true)
        {
            //AnimationController.Instance.animator.enabled = true;
            sx = 3;
            AnimationController.Instance.animator.enabled = true;
            AnimationController.Instance.IdleMotion();
            if (jumped)
            {
                audioSource1.Stop();
            }
            else
            {
                audioSource1.Play();
            }
            movement += Vector3.right;


        }
        if (Input.GetKey(KeyCode.D) && CanMove == true)
        {
            AnimationController.Instance.animator.enabled = true;
            sx = 4;
            AnimationController.Instance.IdleMotion();
            if (jumped)
            {
                audioSource1.Stop();
            }
            else
            {
                audioSource1.Play();
            }

            movement += Vector3.left;

            //transform.localScale = new Vector3(Mathf.Abs(transform.localScale.x), transform.localScale.y, transform.localScale.z);

        }
        if (cambio == true)
        {
            movement = -movement;
        }
        if (Input.GetKey(KeyCode.P))
        {
            UIController.Instance.ShowPauseScreen();
            Time.timeScale = 0f;
        }
        if (Input.GetKey(KeyCode.Space) && CanMove == true /*&& aTerra==true*/)
        {

            audioSource.Play();
            AnimationController.Instance.Jump();
            //rb.AddForce(Vector3.up * 0.25f, ForceMode.Impulse);
            jumped = true;
            velocitaVerticale = Mathf.Sqrt(2 * altezzaSalto);
            //StartCoroutine(secondi());
            //rb.constraints = RigidbodyConstraints.None;


        }
        if (jumped)
        {
            // Muove verso l'alto
            transform.position += Vector3.up * velocitaVerticale * Time.deltaTime;
            // Decrementa la velocità verticale per simulare la gravità zero (nessuna accelerazione)
            // Puoi aggiustare questa logica come preferisci
            velocitaVerticale -= 0; // gravità uguale a 0, quindi niente decremento

            // Condizione per terminare il salto (ad esempio, raggiunta l'altezza desiderata)
            if (transform.position.y >= altezzaSalto)
            {
                // Inizia la discesa
                jumped = false;
            }
        }
        else
        {
            // Durante la discesa, puoi decidere di far tornare l'oggetto a terra
            // Ad esempio, riportarlo a una posizione di terra
            if (transform.position.y > 0)
            {
                transform.position -= Vector3.up * altezzaSalto * Time.deltaTime;
                if (transform.position.y <= 0.77f)
                {
                    transform.position = new Vector3(transform.position.x, 0.77f, transform.position.z);
                }
            }
        }
        //if (aTerra)
        //{

        //    //rb.useGravity = false;
        //}
        //else
        //{
        //    rb.useGravity = true;
        //}


        // Normalizza il vettore per evitare di muoversi pi� velocemente diagonali
        movement = movement.normalized;

        // Applica il movimento
        transform.Translate(movement * speed * Time.deltaTime);

        if (CanMove == false)
        {
            movement = Vector3.zero;
            //sx = 0;
        }
        if (DamageMeter.Instance.allcolor == true && fakingdeathbutton == false)
        {

            Owl.SetActive(true);

        }


    }

    public void fakingButton()
    {
        CanMove = false;
        AnimationController.Instance.FakeDeath();
        fakingdeathbutton = true;
        fakingdeath = true;

        StartCoroutine(ToggleBoolRoutine());

    }
    IEnumerator ToggleBoolRoutine()
    {



        //    }
        yield return new WaitForSeconds(3f); // Attende 4 secondi

        //AnimationController.Instance.noScreamin();
        CanMove = true;
        fakingdeath = false; // Torna a false
        fakingdeathbutton = false;


    }




    public void screamButton()
    {
        CanMove = false;
        AnimationController.Instance.Scremin();
        screambutton = true;
        scream = true;
        StartCoroutine(ToggleBoolRoutine2());

    }


    IEnumerator ToggleBoolRoutine2()
    {

        yield return new WaitForSeconds(5f); // Attende 4 secondi



        //AnimationController.Instance.noScreamin();
        CanMove = true;
        scream = false; // Torna a false
        screambutton = false;

    }

    private void OnTriggerEnter(Collider other)
    {
        // Puoi verificare il tag dell'oggetto che entra nel trigger
        if (other.CompareTag("Terra"))
        {

            aTerra = true;

            Debug.Log("Il giocatore è entrato nel trigger!");
        }

        if (other.CompareTag("Jumpable"))
        {
            //CanMove = false;
            //rb.constraints = RigidbodyConstraints.FreezePositionY;

            if (jumped)
            {
                transform.position = new Vector3(transform.position.x, 2, transform.position.z);
                rb.constraints = RigidbodyConstraints.FreezePositionY | RigidbodyConstraints.FreezeRotationY;
                rb.useGravity = false;

                StartCoroutine(seconds());
            }


        }
        if (other.CompareTag("Jumpable2"))
        {
            //CanMove = false;
            //rb.constraints = RigidbodyConstraints.FreezePositionY;

            //rb.constraints = RigidbodyConstraints.FreezePositionY | RigidbodyConstraints.FreezeRotationY;
            //transform.position = new Vector3(transform.position.x, 1.51f, transform.position.z);
            //rb.useGravity = false;
            //rb.constraints = RigidbodyConstraints.None;
            //rb.constraints = RigidbodyConstraints.FreezePositionY | RigidbodyConstraints.FreezeRotationY;

            //transform.position = new Vector3(5.61999989f, 1.93099999f, -19.9400005f);
            //transform.position = RespawnPosition;
            //CanMove = true;
            //CanMove = false;
            StartCoroutine(seconds());


        }
        if (other.CompareTag("Jumpable3"))
        {
            //CanMove = false;
            //rb.constraints = RigidbodyConstraints.FreezePositionY;

            //rb.constraints = RigidbodyConstraints.FreezePositionY | RigidbodyConstraints.FreezeRotationY;
            //transform.position = new Vector3(transform.position.x, 3f, transform.position.z);
            //rb.useGravity = false;
            //rb.constraints = RigidbodyConstraints.None;
            //rb.constraints = RigidbodyConstraints.FreezePositionY | RigidbodyConstraints.FreezeRotationY;
            altezzaSalto = 12;
            //transform.position = new Vector3(5.61999989f, 1.93099999f, -19.9400005f);
            //transform.position = RespawnPosition;
            //CanMove = true;
            //CanMove = false;
            StartCoroutine(seconds());

        }
        if (other.CompareTag("Jumpable4"))
        {
            //CanMove = false;
            //rb.constraints = RigidbodyConstraints.FreezePositionY;

            //rb.constraints = RigidbodyConstraints.FreezePositionY | RigidbodyConstraints.FreezeRotationY;
            //transform.position = new Vector3(transform.position.x, 4, transform.position.z);
            altezzaSalto = 16;
            //rb.useGravity = false;
            //rb.constraints = RigidbodyConstraints.None;
            //rb.constraints = RigidbodyConstraints.FreezePositionY | RigidbodyConstraints.FreezeRotationY;

            //transform.position = new Vector3(5.61999989f, 1.93099999f, -19.9400005f);
            //transform.position = RespawnPosition;
            //CanMove = true;
            //CanMove = false;
            StartCoroutine(seconds());



        }
        if (other.CompareTag("Untouchable"))
        {
            //CanMove = false;
            //transform.position = Favosition.transform.position;
            cambio = true;
            //transform.position = RespawnPosition;
            //CanMove = true;
            //CanMove = false;

            StartCoroutine(seconds());

        }
        if (other.CompareTag("Breakable"))
        {
            if (KidSkillController.Instance.KidsCounter == 2)
            {

            }
            else
            {
                transform.position = Favosition.transform.position;
            }


        }
        if (other.CompareTag("Bounds"))
        {

            GameController.Instance.GameOver();



        }
        if (other.CompareTag("Win"))
        {

            GameController.Instance.EndGame();



        }
    }
    private void OnTriggerExit(Collider other)
    {
        // Puoi verificare il tag dell'oggetto che esce dal trigger
        if (other.CompareTag("Terra") && jumped == true)
        {

            rb.useGravity = true;
            Debug.Log("Il giocatore è uscito dal trigger!");
            aTerra = false;
            jumped = false;
        }
        if (other.CompareTag("Jumpable"))
        {

            rb.constraints = RigidbodyConstraints.None;
            altezzaSalto = 2;


        }
        if (other.CompareTag("Untouchable"))
        {

            cambio = false;

        }
        if (other.CompareTag("Jumpable4"))
        {

            altezzaSalto = 2;


        }
        if (other.CompareTag("Jumpable2"))
        {

            altezzaSalto = 2;


        }
        if (other.CompareTag("Jumpable3"))
        {

            altezzaSalto = 2;


        }
    }
    IEnumerator secondi()
    {
        yield return new WaitForSeconds(2f);
        rb.constraints = RigidbodyConstraints.FreezePositionY | RigidbodyConstraints.FreezeRotationY;
    }

    IEnumerator seconds()
    {
        yield return new WaitForSeconds(2f);
        CanMove = true;
    }

    
}

