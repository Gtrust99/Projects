using UnityEngine;

public class AudioMenuController : MonoSingleton<AudioMenuController>
{
    public AudioSource MouseNav;
    public AudioSource MouseClick;

    public void Mouseclick()
    {
        MouseClick.Play();
    }
    public void Mousenav()
    {
        MouseNav.Play();
    }
}
