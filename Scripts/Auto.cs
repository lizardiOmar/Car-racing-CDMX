using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Auto : MonoBehaviour
{
	public float moveSpeed = 10.0f;
	public float turnSpeed = 50.0f; 
	
	public float horizontalInput;
	public float forwardInput;
	
	public GameObject GameObject_Player;
	public Rigidbody RigidBody_Player;
	public Transform Player;
	
	
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        forwardInput = Input.GetAxis("Vertical");
		horizontalInput = Input.GetAxis("Horizontal");
		
        if(Input.GetKey(KeyCode.UpArrow))
            transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
			//RigidBody_Player.velocity=Vector3.forward*moveSpeed* Time.deltaTime;
        
        if(Input.GetKey(KeyCode.DownArrow))
            transform.Translate(-Vector3.forward * moveSpeed * Time.deltaTime);
        
        if(Input.GetKey(KeyCode.LeftArrow))
            transform.Rotate(Vector3.up, -turnSpeed * Time.deltaTime);
        
        if(Input.GetKey(KeyCode.RightArrow))
            transform.Rotate(Vector3.up, turnSpeed * Time.deltaTime);
		if(transform.position.y<0)
			Destroy(GameObject_Player);
    }
	/*
	
    public float vActual = 0.0f;
	public float aceleracion = 0.0f;
	public float inputHorizontal;
	public float inputVertical;
	public float d;
	public float giro_t=90;
	public Vector3 movimiento;
	public Vector3 giro;
	void acelerar()
	{
		//Simulando motor de 4 tiempos
		if(vActual >= 0.0f)
		{
			//PRIMER TIEMPO 0-20KM/H
			if(vActual <= 20.0f)
			{
				aceleracion = 0.5f;
				vActual +=aceleracion;
			}
			if(vActual > 20.0f)
			{
				//SEGUNDO TIEMPO 21-30KM/H
				if(vActual <= 30.0f)
				{
					aceleracion = 0.25f;
					vActual +=aceleracion;
				}
				if(vActual > 30.0f)
				{
					//TERCER TIEMPO 31-40KM/H
					if(vActual <= 35.0f)
					{
						aceleracion = 0.125f;
						vActual +=aceleracion;
					}
					if(vActual > 35.0f)
					{
						//CUARTO TIEMPO 41-45KM/H
						if(vActual <= 40.0f)
						{
							aceleracion = 0.0625f;
							vActual +=aceleracion;
						}
						if(vActual > 40.0f)
						{
							vActual =39.99f;
						}
					}
				}
			}
		}
		d=1f;
		GetComponent<Rigidbody>().velocity=Vector3.right*vActual;
		
	}
	void desacelerar(float d)
	{
		vActual -= aceleracion*2.0f;
		if(vActual<0.0f){
			vActual=0.0f;
		}
		if(d==0f)
		{
			movimiento=Vector3.back*vActual;
			//GetComponent<Rigidbody>().velocity=movimiento;
		}
		if(d==1f)
		{
			movimiento=Vector3.forward*vActual;
			GetComponent<Rigidbody>().velocity=movimiento;
		}
	}
	void reversa()
	{
		if(vActual >= 0.0f)
		{
			if(vActual <= 20.0f)
			{
				aceleracion = 0.25f;
				vActual +=aceleracion;
			}
			if(vActual>20f)
			{
				vActual=20f;
			}
		}
		d=0f;
		GetComponent<Rigidbody>().velocity=Vector3.back*vActual;
	}
	void frenar(float d)
	{
		vActual -= 0.625f;
		if(vActual<0.0f){
			vActual=0.0f;
		}
		if(d==0f)
		{
			GetComponent<Rigidbody>().velocity=Vector3.back*vActual;
		}
		if(d==1f)
		{
			GetComponent<Rigidbody>().velocity=Vector3.forward*vActual;
		}
	}
    
	void Update()
    {
        inputHorizontal = Input.GetAxis("Horizontal");
		
		inputVertical = Input.GetAxis("Vertical");
		
		if(inputVertical > 0.0f)
		{
			acelerar();
		}
		if(inputVertical == 0.0f)
		{
			desacelerar(d);
		}
		if(inputVertical < 0.0f)
		{
			reversa();
		}
		if(Input.GetKey("space"))
		{
			frenar(d);
		}
		
		//giro=Vector3.up*inputHorizontal*giro_t*Time.deltaTime*vActual;
		//transform.Rotate(giro);
		
		GetComponent<Rigidbody>().freezeRotation =true;
		transform.Translate(Vector3.forward* Time.deltaTime*vActual*inputVertical);
		transform.Rotate(Vector3.up, 90*inputHorizontal*Time.deltaTime);
    }*/
}
