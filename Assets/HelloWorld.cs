using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloWorld : MonoBehaviour
{
    // Start is called before the first frame update
    public string myMessage;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(myMessage);
    }
}
