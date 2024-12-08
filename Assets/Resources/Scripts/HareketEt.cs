using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class HareketEt : MonoBehaviour
{
    public Vector3 hareket;
   
     

    void Start()
    {
    }

    void Update()
    {
        transform.Translate(hareket*Time.deltaTime);
    }
}

