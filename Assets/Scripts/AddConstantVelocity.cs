using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using UnityEngine;

public class AddConstantVelocity : MonoBehaviour
{
    [SerializeField]
    Vector3 v3Force;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    // called 100 times per second
    void FixedUpdate()
    {
        GetComponent<Rigidbody>().velocity += v3Force;
    }
}
