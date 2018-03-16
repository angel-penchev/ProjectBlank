﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveObject : MonoBehaviour
{

	
	public GameObject item;
	public GameObject tempParent;
	public Transform guide;



	// Use this for initialization
	void Start()
	{
		item.GetComponent<Rigidbody>().useGravity = true;
	}

	// Update is called once per frame
	void Update()
	{
		if (Input.GetKey(KeyCode.Escape))
			Screen.lockCursor = false;
		else
			Screen.lockCursor = true;

		
	}

	void OnMouseDown()
	{
		
		item.GetComponent<Rigidbody>().useGravity = false;
		item.GetComponent<Rigidbody>().isKinematic = true;
		item.transform.position = guide.transform.position;
		item.transform.rotation = guide.transform.rotation;
		item.transform.parent = tempParent.transform;

	}
	void OnMouseUp()
	{
		item.GetComponent<Rigidbody>().useGravity = true;
		item.GetComponent<Rigidbody>().isKinematic = false;
		item.transform.parent = null;
		item.transform.position = guide.transform.position;
	}

	

}