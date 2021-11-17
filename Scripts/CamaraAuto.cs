using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamaraAuto : MonoBehaviour
{
	public Transform Player;
	public float smoothSpeed = 0.125f;
	private Vector3 offset=new Vector3(0, 4, -8);
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        Vector3 desiredPosition=Player.position+offset;
		Vector3 smoothedPosition=Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
        transform.position=smoothedPosition;
		transform.LookAt(Player);
    }
}
