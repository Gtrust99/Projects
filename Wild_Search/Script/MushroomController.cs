using UnityEngine;

public class MushroomController : MonoBehaviour
{
    public GameObject oggettoSotto; // Assegna l'oggetto sotto dall'Inspector
    public float velocitaDiscesa = 1f; // Velocità di discesa
    public float altezzaTarget = -10f; // Altezza finale

    private bool discesaIniziata = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && !discesaIniziata)
        {
            discesaIniziata = true;
            StartCoroutine(ScendiLentamente());
        }
    }

    private System.Collections.IEnumerator ScendiLentamente()
    {
        Vector3 posizioneIniziale = oggettoSotto.transform.position;
        Vector3 posizioneFinale = new Vector3(posizioneIniziale.x, altezzaTarget, posizioneIniziale.z);

        while (Vector3.Distance(oggettoSotto.transform.position, posizioneFinale) > 0.01f)
        {
            oggettoSotto.transform.position = Vector3.MoveTowards(
                oggettoSotto.transform.position,
                posizioneFinale,
                velocitaDiscesa * Time.deltaTime
            );
            yield return null;
        }

        // (Opzionale) assicura che l'oggetto sia alla posizione finale
        oggettoSotto.transform.position = posizioneFinale;
    }
}
