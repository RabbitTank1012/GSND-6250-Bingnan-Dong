using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lasermoving : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    Vector3 targetPosition = new Vector3(-100, 0, 0);
    float t = 0.5f;     // t的值在[0...1]
    void Update()
    {
        transform.position = Vector3.Lerp(transform.position, targetPosition, t);
    }
}

//Vector3 targetPosition = new Vector3(0, 0, 10);
//float t = 0.5f;     // t的值在[0...1]

//void Update()
//{
  //  transform.position = Vector3.Lerp(transform.position, targetPosition, t);
//}
