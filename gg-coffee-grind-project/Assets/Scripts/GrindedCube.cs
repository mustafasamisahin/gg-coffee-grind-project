using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrindedCube : MonoBehaviour
{
    void Update()
    {
        if (transform.position.y < -1.25f){
            Destroy(gameObject);
        }
    }
}
