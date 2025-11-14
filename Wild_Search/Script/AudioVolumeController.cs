using UnityEngine;
using UnityEngine.UI;
public class AudioVolumeController : MonoBehaviour
{
    public Slider volumeSlider;
    public Slider volumeSlider2;
    // 
    public AudioSource audioSource; // Riferimento all'AudioSource

    void Start()
    {
        // Imposta il valore dello slider in base al volume corrente dell'AudioSource
        volumeSlider.value = audioSource.volume;

        // Aggiungi il listener per il cambio di valore dello slider
        volumeSlider.onValueChanged.AddListener(SetVolume);
    }

    void SetVolume(float volume)
    {
        // Imposta il volume dell'AudioSource in base al valore dello slider
        audioSource.volume = volume;
    }
}
