using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoteMeDemo : MonoBehaviour
{

    public float angularVelocity = 10;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var rot = Quaternion.AngleAxis(angularVelocity * Time.deltaTime, Vector3.up);
        transform.localRotation = rot * transform.localRotation;
    }
}
