using UnityEngine;

public class SaveController : MonoSingleton<SaveController>
{
    public int save1;

    // Update is called once per frame
    void Update()
    {
        save1=KidSkillController.Instance.KidsCounter;
    }
}
