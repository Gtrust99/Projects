using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class DamageMeter : MonoSingleton<DamageMeter>
{
    public Image Image;
    public Image Image1;
    public Image Image2;
    public Image Image3;
    public Image Image4;
    public Image Image5;
    public Image Image6;
    public bool allcolor=false;
    public  int CountingDamage;


         private float timer = 0f;

    void Update()
    {
        if(Player.Instance.fakingdeathbutton || Player.Instance.screambutton)
        {
            CountingDamage = 0;
            allcolor = false;
            timer = 0f;
        }
        timer += Time.deltaTime;
        if (timer >= 5f)
        {
            CountingDamage++;
            timer = 0f;
        }
    
        switch (CountingDamage)
        {
            case 0:
                ZeroDamage();
                break;
            case 1:
                Damage1();
                break;
            case 2:
                Damage2();
                break;
            case 3:
                Damage3();
                break;
            case 4:
                Damage4();
                break;
            case 5:
                Damage5();
                break;
            case 6:
                DamageAll();
                allcolor = true;
                break;

            default:
                Debug.LogWarning("Comando non riconosciuto");
                break;
        }


    }
    void ZeroDamage()
    {
        Image.enabled = false;
        Image1.enabled = false;
        Image2.enabled = false;
        Image3.enabled = false;
        Image4.enabled = false;
        Image5.enabled = false;
        Image6.enabled = true;
    }
    void Damage1()
    {
        Image.enabled = true;
        Image1.enabled = false;
        Image2.enabled = false;
        Image3.enabled = false;
        Image4.enabled = false;
        Image5.enabled = false;
        Image6.enabled = false;
    }
    void Damage2()
    {
        Image.enabled = false;
        Image1.enabled = true;
        Image2.enabled = false;
        Image3.enabled = false;
        Image4.enabled = false;
        Image5.enabled = false;
        Image6.enabled = false;
    }
    void Damage3()
    {
        Image.enabled = false;
        Image1.enabled = false;
        Image2.enabled = true;
        Image3.enabled = false;
        Image4.enabled = false;
        Image5.enabled = false;
        Image6.enabled = false;
    }
    void Damage4()
    {
        Image.enabled = false;
        Image1.enabled = false;
        Image2.enabled = false;
        Image3.enabled = true;
        Image4.enabled = false;
        Image5.enabled = false;
        Image6.enabled = false;
    }
    void Damage5()
    {
        Image.enabled = false;
        Image1.enabled = false;
        Image2.enabled = false;
        Image3.enabled = false;
        Image4.enabled = true;
        Image5.enabled = false;
        Image6.enabled = false;
    }
    void DamageAll()
    {
        Image.enabled = false;
        Image1.enabled = false;
        Image2.enabled = false;
        Image3.enabled = false;
        Image4.enabled = false;
        Image5.enabled = true;
        Image6.enabled = false;

    }
}
