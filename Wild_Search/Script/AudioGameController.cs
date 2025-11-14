using UnityEngine;

public class AudioGameController : MonoSingleton<AudioGameController>
{
    public AudioSource PlayDead;
    public AudioSource Scream;

    public void scream()
    {
        Scream.Play();
    }
    public void Mousenav()
    {
        PlayDead.Play();
    }
}


