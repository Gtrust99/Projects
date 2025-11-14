using UnityEngine;

public class KId : MonoBehaviour
{
   
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void OnTriggerEnter(Collider other)
    {

        // Controlla se l'oggetto ha il tag specifico
        if (other.CompareTag("Player") )
        {
            //if (Input.GetKey(KeyCode.C))
            //{
            KidSkillController.Instance.babyscream.Play();
            KidSkillController.Instance.KidsCounter++;
            gameObject.SetActive(false);
            GameController.Instance.redo = 0;

            //}


        }
    }




    //public class SpriteSpawner : MonoBehaviour
    //{
    //    // La texture o l'immagine del sprite
    //    public Texture2D spriteTexture;

    //    // La posizione dove vuoi posizionare lo sprite
    //    public Vector3 spawnPosition = new Vector3(0, 0, 0);

    ////    void /*Start*/()
    ////    {
    //        // Crea un nuovo sprite dalla texture
    //        Sprite newSprite = Sprite.Create(spriteTexture, new Rect(0, 0, spriteTexture.width, spriteTexture.height), new Vector2(0.5f, 0.5f));

    //        // Crea un nuovo GameObject
    //        GameObject spriteObject = new GameObject("GeneratedSprite");

    //        // Aggiungi uno SpriteRenderer
    //        SpriteRenderer renderer = spriteObject.AddComponent<SpriteRenderer>();
    //        renderer.sprite = newSprite;

    //        // Posiziona lo sprite nella posizione desiderata
    //        spriteObject.transform.position = spawnPosition;
    //    }
    //}
}
