using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Collections;
public class PlayerUI : MonoSingleton<PlayerUI>
{
    public GameObject Icons;
    public GameObject Oppossum;
    public GameObject Kid1;
    public GameObject Kid2;
    public GameObject Kid3;
    public GameObject Kid1f;
    public GameObject Kid2f;
    public GameObject Kid3f;
    bool clicked=true ;
    public Button FDeath;
    public Button Scream;
    public Button FDeathoff;
    public Button Screamoff;
    public TextMeshProUGUI ScreamText;
    public TextMeshProUGUI FakeDeathText;
    public TextMeshProUGUI TextGuide;
    public TextMeshProUGUI TextGuide1;
    private float timer = 0f;
    private int stato = 0; // P
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        if(clicked==true)
        {
            Icons.SetActive(true);
        }
        else
        {
            Icons.SetActive(false);
        }

        if (Player.Instance.fakingdeathbutton || Player.Instance.screambutton)
        {
            FDeath.gameObject.SetActive(false);
            Scream.gameObject.SetActive(false);
            FDeathoff.gameObject.SetActive(true);
            Screamoff.gameObject.SetActive(true);
        }
        else
        {
            FDeathoff.gameObject.SetActive(false);
            Screamoff.gameObject.SetActive(false);
            FDeath.gameObject.SetActive(true);
            Scream.gameObject.SetActive(true);

            
        }

        switch (KidSkillController.Instance.KidsCounter)
        {
            case 0:
                Kid1.SetActive(false);
                Kid2.SetActive(false);
                Kid3.SetActive(false);
                Kid1f.SetActive(true);
                Kid2f.SetActive(true);
                Kid3f.SetActive(true);
                TextGuide.text = "Save your baby , use WASD for moving , Space to jump and P to pause  ";
                TextGuide1.text = "Use PlayDead Button to move away the owl, when the meter is full use Scream Button ";

                break;
            case 1:
                Kid1.SetActive(true);
                Kid2.SetActive(false);
                Kid3.SetActive(false);
                Kid1f.SetActive(false);
                Kid2f.SetActive(true);
                Kid3f.SetActive(true);
                TextGuide.text = "Save your baby , look for a magic rock ";
                TextGuide1.text = " ";
                break;
            case 2:
                Kid1.SetActive(true);
                Kid2.SetActive(true);
                Kid3.SetActive(false);
                Kid1f.SetActive(false);
                Kid2f.SetActive(false);
                Kid3f.SetActive(true);
                TextGuide.text = "Save your baby , now you can break stick look for leaves ";
                TextGuide1.text = " ";
                break;
            case 3:
                Kid1.SetActive(true);
                Kid2.SetActive(true);
                Kid3.SetActive(true);
                Kid1f.SetActive(false);
                Kid2f.SetActive(false);
                Kid3f.SetActive(false);
                TextGuide.text = "Escape with your kids  ";
                TextGuide1.text = " ";
                break;
            default:
              
                break;
        }
       

    }

    public void IconsClicked()
    {
        clicked = !clicked;
    }

   
}
