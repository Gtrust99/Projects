using UnityEngine;
using System.Collections;
public class AnimationController : MonoSingleton<AnimationController>
{
    public Animator animator; // assegna qui l'Animator nel Inspector
    string screamfront = "Screamfront";
   string lateralscreamdx = "lateralscreamdx"; // il nome dell'animazione da partire
     string lateralscreamsx = "lateralscreamsx";
     string screamback = "Screaminback";


     string fakedeathfront = "frontdeath";
     string fakedeathscreamdx = "lateraldeathdx"; // il nome dell'animazione da partire
     string fakedeathscreamsx = "lateraldeathsx";


     string Idle = "Idle";
    string Idleback = "Idleback"; // il nome dell'animazione da partire
    string lateralidlesx = "WalkLeft";
   string lateralidledx = "WalkRight";


    public void Scremin()
    {

        animator.SetInteger("SX", 6);


    }




    public void FakeDeath()
    {

        animator.SetInteger("SX", 5) ; // avvia l'animazione

    }

    public void IdleMotion()
    {
        if (Player.Instance.sx == 3)
        {

            animator.SetInteger("SX", 3);
            //animator.Play(lateralidlesx);
            //StartCoroutine(Duration());

        }
        if (Player.Instance.sx == 4)
        {
            animator.SetInteger("SX", 4);
            //animator.SetBool(lateralidledx, true);
            /*animator.Play(lateralidledx); */// avvia l'animazione
            //StartCoroutine(Duration());
        }
        if (Player.Instance.sx == 1)
        {
            animator.SetInteger("SX", 2); ; // avvia l'animazione
            //StartCoroutine(Duration());
        }
        if (Player.Instance.sx == 2)
        {
            animator.Play(Idleback); // avvia l'animazione
            //StartCoroutine(Duration());
        }
    }
    public void Jump()
    {
        animator.SetInteger("SX", 7);
    }
}
