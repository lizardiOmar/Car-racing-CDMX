using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Barrera : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
	private void OnTriggerEnter(Collider other)
    {
		Color col = new Color(Random.value, Random.value, Random.value);
        GetComponent<Renderer> ().material.color = col;
		other.transform.Translate(0, 1, -5);
		//players = GameObject.FindGameObjectsWithTag("Player");
    }
}
