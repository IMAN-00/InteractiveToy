using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KineticSculpture : MonoBehaviour

{
    
    public Vector3 rotationSpeed = new Vector3(0f, 50f, 0f);
    private Vector3 currentRotation;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
        currentRotation += rotationSpeed * Time.deltaTime;
        transform.rotation = (Quaternion.Euler(currentRotation));
    }
}
