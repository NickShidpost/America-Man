using AC;
using UnityEngine;

public class Testing : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void Tag()
    {
        FindObjectOfType<GlobalVariables>().AddTag("Item 1");
    }
}
