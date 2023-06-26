using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{
    [SerializeField] float steerSpeed = 0.1f;
    [SerializeField] float moveSpeed = .01f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //float steerAmount = Inpu
        transform.Rotate(0, 0, steerSpeed);
        transform.Translate(0, moveSpeed, 0);
    }
}
