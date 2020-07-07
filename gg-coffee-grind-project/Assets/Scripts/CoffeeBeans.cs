using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoffeeBeans : MonoBehaviour
{
    [SerializeField]
    private float delay;
    private bool isGrinded = false;
    private int count = 0;
    private int particleCount = 25;
    private Transform blade;

    void OnCollisionEnter(Collision other)
    {
        if (other.transform.tag == "blade" && !isGrinded)
        {
            blade = other.transform;
            isGrinded = true;
            CreateCoffeeDust();
        }
    }

    void CreateCoffeeDust()
    {
        InvokeRepeating("Spawn", 0.25f, 0.05f);
    }

    void Spawn()
    {
        if (count == particleCount)
        {
            CancelInvoke();
            Destroy(gameObject, delay);
            return;
        }
        Instantiate(Resources.Load("GrindedCube"), new Vector3(0, blade.position.y, 0), Quaternion.Euler(new Vector3(0, 0, 0)));
        count++;
    }

}
