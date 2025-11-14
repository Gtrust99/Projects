using UnityEngine;
using UnityEngine.UI;
public class AudioVolumeController1 : MonoBehaviour
{
    public Slider slider; // Riferimento allo slider
    public AudioSource[] audioSources; // Array di AudioSource
    public Slider slider1; // Riferimento allo slider
    public AudioSource[] audioSources1; // Array di AudioSource
    void Start()
    {
     
    }

    public void OnSliderChanged()
    {
        float volume = slider.value; // Ottieni il valore dello slider (da 0 a 1)
        foreach (AudioSource source in audioSources)
        {
            source.volume = volume; // Imposta il volume di ogni AudioSource
        }

 

    }
    public void OnSliderChanged1()
    {
        float volume = slider1.value; // Ottieni il valore dello slider (da 0 a 1)
        foreach (AudioSource source in audioSources1)
        {
            source.volume = volume; // Imposta il volume di ogni AudioSource
        }



    }
}
