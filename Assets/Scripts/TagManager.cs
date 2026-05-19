using UnityEngine;

public class TagManager : MonoBehaviour
{
    public void SendTag(string Tag)
    {
        FindObjectOfType<GlobalVariables>().AddTag(Tag);
    }

    public void RemoveTag(string Tag)
    {
        FindObjectOfType<GlobalVariables>().RemoveTag(Tag);
    }
}
