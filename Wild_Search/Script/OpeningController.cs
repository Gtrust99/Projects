using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
public class OpeningController : MonoBehaviour
{
    [SerializeField] private CanvasGroup canvasgroup;
    public float fadeDuration = 2f;
    public bool fadein;
    public bool fadeout;
    float timer;
    private void Update()
    {
        if (timer == 0)
        {
            fadein = true;
        }

        timer += Time.deltaTime;

        if (timer >= 5f)
        {
            fadeout = true;
            // Esegui l'azione ogni 5 secondi
            Debug.Log("Cambio ogni 5 secondi");

            // Resetta il timer
            timer = 0f;
        }
        if (fadein)
        {
            if (canvasgroup.alpha < 1)
            {
                canvasgroup.alpha += Time.deltaTime;
                if (canvasgroup.alpha >= 1)
                {
                    fadein = false;
                }
            }
        }
        if (fadeout)
        {
            if (canvasgroup.alpha >= 0)
            {
                canvasgroup.alpha -= Time.deltaTime;
                if (canvasgroup.alpha <= 0)
                {
                    fadeout = false;
                    fadein = true;
                    gameObject.SetActive(false);
                    Opener.Instance.transition++;
                }
            }
        }
    }
}
