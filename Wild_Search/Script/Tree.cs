using UnityEngine;

public class Tree : MonoSingleton<Tree>
{
    public bool piletree=false;

    private void OnTriggerEnter(Collider other)
    {

        // Controlla se l'oggetto ha il tag specifico
        if (other.CompareTag("Player"))
        {

            piletree = true;
            //}


        }
    }
}
