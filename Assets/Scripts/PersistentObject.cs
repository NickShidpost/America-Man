using UnityEngine;

public class PersistentObject : MonoBehaviour
{
    public string ObjectTag = "";

    void Start()
    {
        GlobalVariables GV = FindObjectOfType<GlobalVariables>();

        if (GV.CheckTag(ObjectTag))
        {
            Destroy(gameObject);
        }
    }
}
