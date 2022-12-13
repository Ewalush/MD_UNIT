using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlKube : MonoBehaviour
{
    private float horRot;
    private float verRot;
    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void FixedUpdate(){
        horRot = Input.GetAxis("Horizontal");
        verRot = Input.GetAxis("Vertical");
        Vector3 rotations = new Vector3(-horRot*25, 0.0f, -verRot*25); 

        Quaternion deltaRotation = Quaternion.Euler(rotations * Time.fixedDeltaTime);
        rb.rotation = (rb.rotation * deltaRotation);
    }
}
