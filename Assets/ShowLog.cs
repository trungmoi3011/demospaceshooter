using UnityEngine;

public class ShowLog : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hello World!");
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Update called! " + Time.frameCount);
    }
}