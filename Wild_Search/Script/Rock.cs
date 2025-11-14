using UnityEngine;
using System.Collections;
public class Rock : MonoSingleton<Rock>
{
    public bool unlock;
    public GameObject pos;
    private void Start()
    {
        unlock = false;
    }
    private void OnTriggerEnter(Collider other)
    {

        // Controlla se l'oggetto ha il tag specifico
        if (other.CompareTag("Player") && KidSkillController.Instance.UnlockSkillrock)
        {
            unlock = true;
            gameObject.SetActive(false);

            //transform.position = pos.transform.position ;
           
    //        StartCoroutine(Reset());


        }
    }

    //IEnumerator Reset()
    //{
    //    yield return new WaitForSeconds(10f);
    //    transform.position = position;
    //}

}
