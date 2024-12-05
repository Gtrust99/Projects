using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    public int choosingcharacter1;
    public int choosingcharacter2;
    int character;
    int character2;
    public Player Player;
    public Player2 Player2;
    public Transform PL;
    public Transform PL2;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (choosingcharacter1 == 1)
        {
            Vector3 spawnPosition = new Vector3(0, 0, 0);
            if (Input.GetKey(KeyCode.Alpha1))
            {

                character = 1;
                GameObject p = Instantiate(Player.zero, transform.position, Quaternion.identity);
                p.SetActive(true);
                GameObject lastobject = p;
                lastobject.transform.SetParent(PL);
                Destroy(lastobject, 3f);
                choosingcharacter1 = 0;
                choosingcharacter2 = 0;
            }
            if (Input.GetKey(KeyCode.Alpha2))
            {
                character = 2;
                GameObject p = Instantiate(Player.one, transform.position, Quaternion.identity);
                p.SetActive(true);
                GameObject lastobject = p;
                lastobject.transform.SetParent(PL);
                Destroy(lastobject, 3f);
                choosingcharacter1 = 0;
                choosingcharacter2 = 0;
            }
            if (Input.GetKey(KeyCode.Alpha3))
            {
                character = 3;
                GameObject p = Instantiate(Player.two, transform.position, Quaternion.identity);
                p.SetActive(true);
                GameObject lastobject = p;
                lastobject.transform.SetParent(PL);
                Destroy(lastobject, 3f);
                choosingcharacter1 = 0;
                choosingcharacter2 = 0;
            }
            if (Input.GetKey(KeyCode.Alpha4))
            {
                character = 4;
                GameObject p = Instantiate(Player.three, transform.position, Quaternion.identity);
                p.SetActive(true);
                GameObject lastobject = p;
                lastobject.transform.SetParent(PL);
                Destroy(lastobject, 3f);
                choosingcharacter1 = 0;
                choosingcharacter2 = 0;
            }
            if (Input.GetKey(KeyCode.Alpha5))
            {
                Vector3 position = new Vector3(0, 0, 0);
                character = 5;
                transform.position = position;
                GameObject p = Instantiate(Player.four, transform.position, Quaternion.identity);
                p.SetActive(true);
                GameObject lastobject = p;
                lastobject.transform.SetParent(PL);
                Destroy(lastobject, 3f);
                lastobject.SetActive(true);
                choosingcharacter1 = 0;
                choosingcharacter2 = 0;
            }
        }
        if (choosingcharacter2 == 1)
        {
            Vector3 spawnPosition = new Vector3(0, 0, 0);
            if (Input.GetKey(KeyCode.Alpha1))
            {

                character2 = 1;
                GameObject p = Instantiate(Player2.zero, transform.position, Quaternion.identity);
                p.SetActive(true);
                GameObject lastobject = p;
                lastobject.transform.SetParent(PL2);
                Destroy(lastobject, 3f);
                choosingcharacter1 = 0;
                choosingcharacter2 = 0;

            }
            if (Input.GetKey(KeyCode.Alpha2))
            {
                character2 = 2;
                GameObject p = Instantiate(Player2.one, transform.position, Quaternion.identity);
                p.SetActive(true);
                GameObject lastobject = p;
                lastobject.transform.SetParent(PL2);
                Destroy(lastobject, 3f);

                choosingcharacter1 = 0;
                choosingcharacter2 = 0;
            }
            if (Input.GetKey(KeyCode.Alpha3))
            {
                character2 = 3;
                GameObject p = Instantiate(Player2.two, transform.position, Quaternion.identity);
                p.SetActive(true);
                GameObject lastobject = p;
                lastobject.transform.SetParent(PL2);
                Destroy(lastobject, 3f);
                choosingcharacter1 = 0;
                choosingcharacter2 = 0;
            }
            if (Input.GetKey(KeyCode.Alpha4))
            {
                character = 4;
                GameObject p = Instantiate(Player2.three, transform.position, Quaternion.identity);
                p.SetActive(true);
                GameObject lastobject = p;
                lastobject.transform.SetParent(PL2);
                Destroy(lastobject, 3f);
                choosingcharacter1 = 0;
                choosingcharacter2 = 0;
            }
            if (Input.GetKey(KeyCode.Alpha5))
            {
                character = 5;
                GameObject p = Instantiate(Player2.four, transform.position, Quaternion.identity);
                p.SetActive(true);
                GameObject lastobject = p;
                lastobject.transform.SetParent(PL2);
                Destroy(lastobject, 3f);
                choosingcharacter1 = 0;
                choosingcharacter2 = 0;
            }
        }

    }
    public void StartCaracter()
    {
        if (character == 1)
        {
            Vector3 position = new Vector3(-10, 0, 0);
            Player.Model0.SetActive(true);
            Player.Model1.SetActive(false);
            Player.Model2.SetActive(false);
            Player.Model3.SetActive(false);
            Player.Model4.SetActive(false);

        }
        if (character == 2)
        {
            Vector3 position = new Vector3(-10, 0, 0);
            Player.Model0.SetActive(false);
            Player.Model1.SetActive(true);
            Player.Model2.SetActive(false);
            Player.Model3.SetActive(false);
            Player.Model4.SetActive(false);
        }
        if (character == 3)
        {
            Vector3 position = new Vector3(-10, 0, 0);
            Player.Model0.SetActive(false);
            Player.Model1.SetActive(false);
            Player.Model2.SetActive(true);
            Player.Model3.SetActive(false);
            Player.Model4.SetActive(false);

        }
        if (character == 4)
        {
            Vector3 position = new Vector3(-10, 0, 0);
            Player.Model0.SetActive(false);
            Player.Model1.SetActive(false);
            Player.Model2.SetActive(false);
            Player.Model3.SetActive(true);
            Player.Model4.SetActive(false);

        }
        if (character == 5)
        {
            Vector3 position = new Vector3(-10, 0, 0);
            Player.Model0.SetActive(false);
            Player.Model1.SetActive(false);
            Player.Model2.SetActive(false);
            Player.Model3.SetActive(false);
            Player.Model4.SetActive(true);
        }
    }
    public void StartCharacter2()
    {
        if (character2 == 1)
        {
            Vector3 position = new Vector3(10, 0, 0);
            Player2.Model0.SetActive(true);
            Player2.Model1.SetActive(false);
            Player2.Model2.SetActive(false);
            Player2.Model3.SetActive(false);
            Player2.Model4.SetActive(false);
        }
        if (character2 == 2)
        {
            Vector3 position = new Vector3(10, 0, 0);
            Player2.Model0.SetActive(false);
            Player2.Model1.SetActive(true);
            Player2.Model2.SetActive(false);
            Player2.Model3.SetActive(false);
            Player2.Model4.SetActive(false);
        }
        if (character2 == 3)
        {
            Vector3 position = new Vector3(10, 0, 0);
            Player2.Model0.SetActive(false);
            Player2.Model1.SetActive(false);
            Player2.Model2.SetActive(true);
            Player2.Model3.SetActive(false);
            Player2.Model4.SetActive(false);
        }
        if (character2 == 4)
        {
            Vector3 position = new Vector3(10, 0, 0);
            Player2.Model0.SetActive(true);
            Player2.Model1.SetActive(false);
            Player2.Model2.SetActive(false);
            Player2.Model3.SetActive(true);
            Player2.Model4.SetActive(false);
        }
        if (character2 == 5)
        {
            Vector3 position = new Vector3(10, 0, 0);
            Player2.Model0.SetActive(true);
            Player2.Model1.SetActive(false);
            Player2.Model2.SetActive(false);
            Player2.Model3.SetActive(false);
            Player2.Model4.SetActive(true);
        }
    }
}

