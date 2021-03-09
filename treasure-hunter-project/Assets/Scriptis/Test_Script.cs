using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test_Script : MonoBehaviour
{

    //This variable is editable in unity!
    public string startMessage;
    public string updateMessage;
    // Start is called before the first frame update
    void Start()
    {
        Debug.LogError(startMessage);
    }

    // Update is called once per frame
    void Update()
    {
        Debug.LogWarning(updateMessage);
    }
}
