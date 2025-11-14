using UnityEngine;
using System.Collections.Generic;

public class StickController : MonoBehaviour
{
    public List<GameObject> Sticks;

    // Update is called once per frame
    void Update()
    {
        if (GameController.Instance.redo == 1)
        {
            foreach (GameObject obj in Sticks)
            {
                if (obj != null)
                {
                    obj.SetActive(true);
                }
            }
        }
    }
}
