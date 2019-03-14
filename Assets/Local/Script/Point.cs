using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Point : MonoBehaviour
{
	Vector3 pointPos;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
		pointPos = Camera.main.ScreenToWorldPoint(Input.mousePosition+new Vector3(0f,0f,10f));
		pointPos.z = gameObject.transform.position.z;
		gameObject.transform.position = pointPos;
    }
}
