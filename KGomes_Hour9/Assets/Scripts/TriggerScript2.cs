using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerScript2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter(Collider other)
    {
        print(other.gameObject.name + " has entered Tigger");
    }
    void OnTriggerStay(Collider other)
    {
        print(other.gameObject.name + " is still in Trigger");
    }
    void OnTriggerExit(Collider other)
    {
        print(other.gameObject.name + " has left Tigger");
    }
}
