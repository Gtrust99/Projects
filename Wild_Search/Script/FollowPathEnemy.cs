using UnityEngine;

public class FollowPathEnemy : MonoBehaviour
{
    public Transform[] waypoints; // Array di punti di passaggio
    public float speed = 5f; // Velocità di movimento
    private int currentWaypointIndex = 0;
    private bool isWaiting = false; // Per controllare la pausa

    void Update()
    {
        if (waypoints.Length == 0)
            return;

        // Movimento verso il waypoint corrente
        Transform targetWaypoint = waypoints[currentWaypointIndex];
        Vector3 direction = targetWaypoint.position - transform.position;
        float distanceThisFrame = speed * Time.deltaTime;

        if (direction.magnitude <= distanceThisFrame)
        {
            // Arrivato al waypoint, passa al successivo
            //StartCoroutine(WaitAtWaypoint());
            currentWaypointIndex++;
            transform.rotation = Quaternion.Euler(transform.rotation.eulerAngles + new Vector3(0, 0, transform.rotation.z + 90));
            if (currentWaypointIndex >= waypoints.Length)
            {
                currentWaypointIndex = 0; // Ricomincia il percorso

            }
        }
        else
        {
            // Muovi verso il waypoint
            transform.Translate(direction.normalized * distanceThisFrame, Space.World);
           
        }
    }

}

