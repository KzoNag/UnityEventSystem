using UnityEngine;
using UnityEngine.Events;

using System.Collections;

public class MouseEventExecuter : MonoBehaviour 
{
	[System.Serializable]
	public class MouseEvent : UnityEvent<Vector3>{}

	public MouseEvent onMouseDown;
	public MouseEvent onMouseUp;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (Input.GetMouseButtonDown (0)) 
		{
			onMouseDown.Invoke (Input.mousePosition);
		}
	
		if (Input.GetMouseButtonUp (0)) 
		{
			onMouseUp.Invoke (Input.mousePosition);
		}
	}
}
