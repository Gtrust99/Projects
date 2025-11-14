using UnityEngine;

public class OwlShadowController : MonoSingleton<OwlShadowController>
{
    public AudioSource Owlin;
    public AudioSource Owlout;
    public bool OwlBigShadow=true;
    public float increaseRate = 2f; // incremento per secondo
    public float maxScaleZ = 14f;       // scala Z massima
    public Vector3 initialScale;
    //void Awake()
    //{
    //    DontDestroyOnLoad(gameObject);
    //    initialScale = transform.localScale;
    //    Owlin.Play();
    //}
    //private void Start()
    //{
    //    Owlin.Play();
    //    initialScale = transform.localScale;
    //    gameObject.SetActive(false);
    //}
    //void Update()
    //{
    //    // Se la scala Z è già al massimo, non fare nulla
    //    if (transform.localScale.z >= maxScaleZ)
    //        return;


    //    // Calcola l'incremento basato sul deltaTime
    //    float increment = increaseRate * Time.deltaTime;

    //        // Aggiorna la scala dell'oggetto
    //        Vector3 newScale = transform.localScale;
    //        newScale.z += increment;

    //        // Assicura di non superare il massimo
    //        if (newScale.z > maxScaleZ)
    //        {
    //            newScale.z = maxScaleZ;

    //            transform.localScale = newScale;

    //            GameController.Instance.GameOver();
    //        }



    //    if (Player.Instance.screambutton)
    //    {
    //        Owlout.Play();
    //        transform.localScale = initialScale;
    //        gameObject.SetActive(false);
    //        //OwlBigShadow = false;
    //    }
    //}
    void Start()
    {
        Owlin.Play();
        initialScale = transform.localScale;
        //gameObject.SetActive(false);
        Debug.Log("Start: initialScale = " + initialScale);
    }

    void Update()
    {
        Debug.Log("Update chiamato");
        transform.position = new Vector3(transform.position.x,0.77f,transform.position.z);
        if (transform.localScale.z >= maxScaleZ)
        {
            Debug.Log("Scala massima raggiunta");
            return;
        }

        float increment = increaseRate * Time.deltaTime;
        Debug.Log("Increment: " + increment);
        Vector3 newScale = transform.localScale;
        newScale.z += increment;
        Debug.Log("Nuova scala Z: " + newScale.z);

        if (newScale.z >= maxScaleZ)
        {
            newScale.z = maxScaleZ;
            Debug.Log("Scala raggiunta, chiamata GameOver");
            transform.localScale = newScale;
            GameController.Instance.GameOver();
        }
        else
        {
            transform.localScale = newScale;
        }

        if (Player.Instance.screambutton)
        {
            Debug.Log("Pulsante premuto");
            Owlout.Play();
            transform.localScale = initialScale;
            gameObject.SetActive(false);
        }
    }
}
