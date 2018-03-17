using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class buttonPress : MonoBehaviour {

	
	public List<int> codeNow = new List<int>();
	public List<int> constantCode = new List<int>() { 1, 9, 8, 8 };
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
	{
		
		if(codeNow.SequenceEqual(constantCode))
		{
			Debug.Log("Its Alive!!!");
		}
        int lSize = codeNow.Count;
		if (lSize >= 4)
		{
			codeNow.Clear();
		}
		
	}
}
