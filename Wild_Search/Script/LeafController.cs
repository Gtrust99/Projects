using UnityEngine;

public class LeafController : MonoSingleton<LeafController>
{
    public GameObject Pile;
    public GameObject Kid3;
    public int leafCounter;
    void Start()
    {
        Pile.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (/*Input.GetKey(KeyCode.C) && */leafCounter == 3 && Tree.Instance.piletree)
        {

            Pile.SetActive(true);
            Kid3.transform.position = new Vector3(Pile.transform.position.x,1.2f,Pile.transform.position.z);
            
        }
    }


}
