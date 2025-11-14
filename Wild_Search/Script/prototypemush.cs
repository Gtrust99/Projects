using UnityEngine;

public class prototypemush : MonoBehaviour
{
    //    //private void OnTriggerEnter(Collider other)
    //    //{
    //    //    Debug.Log("Oggetto entrato nel trigger: " + other.gameObject.name);

    //    //    // Puoi aggiungere altre azioni qui, ad esempio:
    //    //    // Se vuoi distruggere l'oggetto che entra:
    //    //    // Destroy(other.gameObject);
    //    //}
    //    public float dropDistance = 2f; // distanza di discesa
    //    public float moveSpeed = 2f; // velocità del movimento
    //    private Vector3 originalPosition;
    //    private Vector3 targetPosition;
    //    private bool isMovingDown = false;
    //    private bool isMovingUp = false;

    //    void Start()
    //    {
    //        originalPosition = transform.position;
    //        targetPosition = originalPosition;
    //    }

    //    private void OnTriggerEnter(Collider other)
    //    {
    //        if (other.CompareTag("Player"))
    //        {
    //            // Imposta la posizione target per scendere
    //            targetPosition = originalPosition - new Vector3(0, dropDistance, 0);
    //            isMovingDown = true;
    //            isMovingUp = false;
    //        }
    //    }

    //    private void OnTriggerExit(Collider other)
    //    {
    //        if (other.CompareTag("Player"))
    //        {
    //            // Imposta la posizione originale per risalire
    //            targetPosition = originalPosition;
    //            isMovingUp = true;
    //            isMovingDown = false;
    //        }
    //    }

    //    void Update()
    //    {
    //        if (isMovingDown && !isMovingUp)
    //        {
    //            transform.position = Vector3.MoveTowards(transform.position, targetPosition, moveSpeed * Time.deltaTime);
    //            if (Vector3.Distance(transform.position, targetPosition) < 0.01f)
    //            {
    //                isMovingDown = false;
    //            }
    //        }
    //        else if (isMovingUp && !isMovingDown)
    //        {
    //            transform.position = Vector3.MoveTowards(transform.position, targetPosition, moveSpeed * Time.deltaTime);
    //            if (Vector3.Distance(transform.position, targetPosition) < 0.01f)
    //            {
    //                isMovingUp = false;
    //            }
    //        }
    //    }
    public float dropDistance = 2f; // distanza di discesa dell'oggetto principale
    public float moveSpeed = 0.1f; // velocità del movimento
    public GameObject secondaryObject; // Oggetto secondario da far scendere
    private Vector3 originalPosition;
    private Vector3 targetPosition;
    private Vector3 secondaryTargetPosition;
    private bool isMoving = false;
    private bool movingDown = false;

    void Start()
    {
        originalPosition = transform.position;
        targetPosition = originalPosition;

        // Se l'oggetto secondario è assegnato, calcola la sua posizione di destinazione
        if (secondaryObject != null)
        {
            secondaryTargetPosition = secondaryObject.transform.position - new Vector3(0, dropDistance / 2f, 0);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && KidSkillController.Instance.UnlockSkillrock)
        {
            // Imposta le posizioni target per entrambi gli oggetti
            targetPosition = originalPosition - new Vector3(0, dropDistance, 0);
            isMoving = true;
            movingDown = true;

            if (secondaryObject != null)
            {
                secondaryTargetPosition = secondaryObject.transform.position - new Vector3(0, dropDistance / 2f, 0);
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            // Risale alla posizione originale
            targetPosition = originalPosition;
            isMoving = true;
            movingDown = false;

            if (secondaryObject != null)
            {
                secondaryTargetPosition = secondaryObject.transform.position + new Vector3(0, dropDistance / 2f, 0);
            }
        }
    }

    void Update()
    {
        if (isMoving)
        {
            // Muove l'oggetto principale
            transform.position = Vector3.MoveTowards(transform.position, targetPosition, moveSpeed * Time.deltaTime);
            // Muove l'oggetto secondario, se assegnato
            if (secondaryObject != null)
            {
                secondaryObject.transform.position = Vector3.MoveTowards(secondaryObject.transform.position, secondaryTargetPosition, moveSpeed * Time.deltaTime);
            }

            // Controlla se entrambi hanno raggiunto le destinazioni
            bool mainArrived = Vector3.Distance(transform.position, targetPosition) < 0.001f;
            bool secondaryArrived = true;
            if (secondaryObject != null)
            {
                secondaryArrived = Vector3.Distance(secondaryObject.transform.position, secondaryTargetPosition) < 0.001f;
            }

            if (mainArrived && secondaryArrived)
            {
                // Imposta le posizioni precise
                transform.position = targetPosition;
                if (secondaryObject != null)
                {
                    secondaryObject.transform.position = secondaryTargetPosition;
                }
                isMoving = false;
            }
        }
    }
}
