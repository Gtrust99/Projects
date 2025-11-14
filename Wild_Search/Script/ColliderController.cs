using UnityEngine;

public class ColliderController : MonoSingleton<ColliderController>
{
    public GameObject object1;
    public GameObject object2;
    public GameObject object3;

    // Metodo per attivare i Collider
    public void ActivateColliders()
    {
        if (object1 != null  )
        {
            Collider col1 = object1.GetComponent<Collider>();
            if (col1 != null)
                col1.enabled = true;
        }

        if (object2 != null)
        {
            Collider col2 = object2.GetComponent<Collider>();
            if (col2 != null)
                col2.enabled = true;
        }

        if (object3 != null)
        {
            Collider col3 = object3.GetComponent<Collider>();
            if (col3 != null)
                col3.enabled = true;
        }
    }

    // Metodo per disattivare i Collider
    public void DeactivateColliders()
    {
        if (object1 != null  )
        {
            Collider col1 = object1.GetComponent<Collider>();
            if (col1 != null)
                col1.enabled = false;
        }

        if (object2 != null)
        {
            Collider col2 = object2.GetComponent<Collider>();
            if (col2 != null)
                col2.enabled = false;
        }

        if (object3 != null)
        {
            Collider col3 = object3.GetComponent<Collider>();
            if (col3 != null)
                col3.enabled = false;
        }
    }
}
