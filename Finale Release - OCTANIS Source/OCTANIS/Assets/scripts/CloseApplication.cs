using UnityEngine;
using System.Collections;

public class CloseApplication : MonoBehaviour 
{
	void Update () 
	{
		if(Input.GetKey(KeyCode.Escape))
		{
			Application.Quit ();
		}
	}
}
