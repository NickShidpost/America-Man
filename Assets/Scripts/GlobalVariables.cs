using System.Collections.Generic;
using UnityEngine;

public class GlobalVariables : MonoBehaviour
{
    public AC.Player player;
    public List<string> SaveFileTags = new List<string>();

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void AddTag(string Tag)
    {
        if (!SaveFileTags.Contains(Tag))
        {
            SaveFileTags.Add(Tag);
        }
    }

    public void RemoveTag(string Tag)
    {
        if (SaveFileTags.Contains(Tag))
        {
            SaveFileTags.Remove(Tag);
        }
    }

    public bool CheckTag(string Tag)
    {
        bool Check = false;

        if (SaveFileTags.Contains(Tag)) Check = true;

        return Check;
    }
}
