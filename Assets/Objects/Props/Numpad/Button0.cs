using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button0 : MonoBehaviour
{


	public buttonPress bp;
	public int but0 = 0;
	
	// Use this for initialization
	void Start()
	{

	}

	// Update is called once per frame
	void Update()
	{

	}

	void OnMouseDown()
	{
		bp.codeNow.Add(but0);

	}
}
