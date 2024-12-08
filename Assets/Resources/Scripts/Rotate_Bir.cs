using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Rotate_Bir : MonoBehaviour
{
    public Vector3 vect;
    public int xi,yi,zi;
     

    void Start()
    {
vect = new Vector3(xi,yi,zi);
    }

    void Update()
    {
        transform.Rotate(vect*Time.deltaTime);
    }
}
