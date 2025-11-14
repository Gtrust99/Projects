using UnityEngine;

public class Teleport : MonoBehaviour
{
    //public Vector3 teleportPosition; // La posizione di destinazione
    public Transform teleportPosition;
    private void OnTriggerEnter(Collider other)
    {
        // Verifica se il collider che entra è il giocatore
        if (other.CompareTag("Player"))
        {
            Debug.Log("Il giocatore è entrato nel trigger e verrà teletrasportato.");
            other.transform.position = teleportPosition.position;
        }
    }
}
