using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float Speed;
    [SerializeField] private float turnSpeed;
    [SerializeField] private float horizontalInput;
    [SerializeField] private float verticalInput;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.forward * Speed*Time.deltaTime*verticalInput);
        transform.Rotate(Vector3.up* Time.deltaTime*turnSpeed*horizontalInput);

    }
}
