using UnityEngine;

public class KidSkillController : MonoSingleton<KidSkillController>
{
    public AudioSource babyscream;
    public int KidsCounter;
    public bool UnlockSkillwood;
    public bool UnlockSkillrock;
    public GameObject Kid1;
    public GameObject Kid2;
    public GameObject Kid3;
    // Start is called once before the first execution of Update after the MonoBehaviour is created


    // Update is called once per frame
    void Update()
    {
        if(KidsCounter==1)
        {
            UnlockSkillrock = true;
            Kid1.SetActive(false);
        }
        if(KidsCounter==2)
        {
            UnlockSkillwood = true;
            Kid2.SetActive(false);
        }
        if (KidsCounter == 3)
        {
            
            Kid3.SetActive(false);
        }
      

        if (GameController.Instance.redo == 1)
        {
            Kid1.SetActive(true);
            Kid2.SetActive(true);
            Kid3.SetActive(true);
        }
    }
}
