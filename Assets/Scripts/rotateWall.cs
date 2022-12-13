using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotateWall : MonoBehaviour
{
    float speed;
    // Start is called before the first frame update
    void Start()
    {
        speed = 1;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(0, 30, 0) * Time.deltaTime * speed);
    }
}
