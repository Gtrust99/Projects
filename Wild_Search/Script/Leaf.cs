using UnityEngine;

public class Leaf : MonoBehaviour
{

    private void Start()
    {
        gameObject.SetActive(true);
    }
    private void OnTriggerEnter(Collider other)
    {
        
        // Controlla se l'oggetto ha il tag specifico
        if (other.CompareTag("Player"))
        {
            //if(Input.GetKey(KeyCode.C))
            //{
            LeafController.Instance.leafCounter++;
            gameObject.SetActive(false);

                
            //}
            

        }
    }
}
