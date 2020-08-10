using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class User : MonoBehaviour
{
    private Rigidbody rb;
	public float speed;
	public float maxSpeed;
	public GameObject Referencia;
	
	// Start is called before the first frame update
    void Start()
    {
		rb = GetComponent<Rigidbody>();        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float moverHorizontal = Input.GetAxis("Horizontal");
		float moverVertical = Input.GetAxis("Vertical");
		
		if(rb.velocity.magnitude > maxSpeed){
			rb.velocity = rb.velocity.normalized * maxSpeed;
		}
						
		rb.AddForce(Referencia.transform.forward * moverVertical * speed);
		rb.AddForce(Referencia.transform.right * moverHorizontal * speed);
		
    }
}
