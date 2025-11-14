using UnityEngine;

public class FeatherController : MonoBehaviour
{

    public float fallSpeed = 2f;       // Velocità di caduta
    public float oscillationAmplitude = 0.5f; // Ampiezza dell'oscillazione laterale
    public float oscillationFrequency = 2f;   // Frequenza dell'oscillazione

    private Vector3 startPosition;
    private float oscillationPhase;

    void Start()
    {
        startPosition = transform.position;
        oscillationPhase = 0f;
    }

    void Update()
    {
        // Movimento di caduta verticale
        transform.Translate(Vector3.down * fallSpeed * Time.deltaTime, Space.World);

        // Movimento oscillante laterale
        oscillationPhase += oscillationFrequency * Time.deltaTime;
        float deltaX = Mathf.Sin(oscillationPhase) * oscillationAmplitude;
        transform.position = new Vector3(startPosition.x + deltaX, transform.position.y, transform.position.z);

        // Se la foglia tocca il suolo o una certa altezza, puoi disattivarla o resetarla
        if (transform.position.y < -10f)
        {
            Destroy(gameObject);
        }
    }

}
