using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloWorld : MonoBehaviour

{
    public string myName;
   
    // Start is called before the first frame update
    void Start()
    {
       Debug.Log("I am alive and my name is " + myName);

    }

    void Update()
    {
      Debug.Log("I am alive and my name is " + myName);
    }
}
