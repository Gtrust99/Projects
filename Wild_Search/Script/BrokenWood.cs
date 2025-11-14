using UnityEngine;

public class BrokenWood : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {

        // Controlla se l'oggetto ha il tag specifico
        if (other.CompareTag("Player"))
        {
            if (/*Input.GetKey(KeyCode.C) &&*/ KidSkillController.Instance.UnlockSkillwood)
            {
                gameObject.SetActive(false);
                GameController.Instance.redo = 0;

            }
            Player.Instance.cambio = true;

            //if (Player.Instance.fakingdeathbutton || Player.Instance.screambutton)
            //{
            //    Player.Instance.CanMove = true;
            //} 
            //Player.Instance.CanMove = false;
            //else
            //{
            //    Player.Instance.CanMove = true;
            //}

        }
    }
}
