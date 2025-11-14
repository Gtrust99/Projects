using UnityEngine;

public class Opener : MonoSingleton<Opener>
{
    public GameObject Op1;
    public GameObject Op2;
    public GameObject Op3;
    public GameObject Op4;
    public int transition;
    public bool play = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        transition = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if(transition==1)
        {
            Op1.SetActive(true);
            Op2.SetActive(false);
            Op3.SetActive(false);
            Op4.SetActive(false);
        }
        if (transition == 2)
        {
            Op1.SetActive(false);
            Op2.SetActive(true);
            Op3.SetActive(false);
            Op4.SetActive(false);
        }
        if (transition == 3)
        {
            Op1.SetActive(false);
            Op2.SetActive(false);
            Op3.SetActive(true);
            Op4.SetActive(false);
        }
        if (transition == 4)
        {
            Op1.SetActive(false);
            Op2.SetActive(false);
            Op3.SetActive(false);
            Op4.SetActive(true);
        }
        if(transition>=5)
        {
            Op1.SetActive(false);
            Op2.SetActive(false);
            Op3.SetActive(false);
            Op4.SetActive(false);
            GameController.Instance.Game.SetActive(true);
            UIController.Instance.ShowPlayerUI();
            UIController.Instance.Opening.Stop();
            //play = true;
            


        }
        if (transition == 0)
        {
            Op1.SetActive(false);
            Op2.SetActive(false);
            Op3.SetActive(false);
            Op4.SetActive(false);

        }
    }
}
