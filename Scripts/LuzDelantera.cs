using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LuzDelantera : MonoBehaviour
{
	private Light foco;
    // Start is called before the first frame update
    void Start()
    {
        foco = GetComponent <Light>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyUp(KeyCode.Space))
        {
            foco.enabled = !foco.enabled;
			//gameObject.SetActive(false);
        }
    }
}
