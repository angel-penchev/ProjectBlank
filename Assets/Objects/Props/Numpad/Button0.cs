using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Button0 : MonoBehaviour
{


	public buttonPress bp;
	public int but0 = 0;
	public Text numpadText;
	

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
		if(but0 == 10)
		{
			bp.codeNow.Clear();
			bp.numpadString = "";
		}
		else
		{
			bp.codeNow.Add(but0);
			bp.numpadString += but0.ToString();
			
		}
		numpadText.text = bp.numpadString;
	}
}
