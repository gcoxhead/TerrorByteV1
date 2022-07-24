using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update

    //private variables. Make public to display in the unity inspector
    [SerializeField] private float speed = 10.0f;
    //[SerializeField] private float horsePower = 0;
    [SerializeField] private float turnSpeed = 90.0f;
    private float horizontalInput;
    private float verticalInput;
    private Rigidbody playerRb;
    //[SerializeField] GameObject centerOfMass;

    //Start is called once on start up
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
        //playerRb.centerOfMass = centerOfMass.transform.position;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //Get player input from controls.
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
        
        //Move the character forward/back.
        
        transform.Translate(Vector3.forward * Time.deltaTime * speed * verticalInput) ;
       
        //Rotate the character.
        transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizontalInput) ;
    }
}
