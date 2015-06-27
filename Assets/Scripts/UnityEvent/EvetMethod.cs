using UnityEngine;
using System.Collections;

public class EvetMethod : MonoBehaviour 
{
//	public MouseEventExecuter executer;
	
	System.Text.StringBuilder text = new System.Text.StringBuilder();

	// Use this for initialization
	void Start () 
	{
	
	}

	void OnEnable()
	{
//		executer.onMouseDown.AddListener (OnMouseDown);
//		executer.onMouseUp.AddListener (OnMouseUp);
	}

	void OnDisable()
	{
//		executer.onMouseDown.RemoveListener (OnMouseDown);
//		executer.onMouseUp.RemoveListener (OnMouseUp);
	}
	
	// Update is called once per frame
	void Update () 
	{
	
	}

	public void OnMouseDown(Vector3 position)
	{
		text.AppendLine("OnMouseDown:" + position.ToString ());
		Debug.Log ("OnMouseDown:" + position.ToString ());
	}

	public void OnMouseUp(Vector3 position)
	{
		text.AppendLine("OnMouseUp:" + position.ToString ());
		Debug.Log ("OnMouseUp:" + position.ToString ());
	}

	public void IntMethod(int value)
	{
		text.AppendLine("IntMethod:" + value.ToString ());
		Debug.Log ("IntMethod:" + value.ToString ());
	}

	public void StringMethod(string value)
	{
		text.AppendLine("StringMethod:" + value.ToString ());
		Debug.Log ("StringMethod:" + value.ToString ());
	}

	public void ObjectMethod(Object obj)
	{
		text.AppendLine("ObjectMethod:" + obj.name.ToString ());
		Debug.Log ("ObjectMethod:" + obj.name.ToString ());
	}

	void OnGUI()
	{
		GUILayout.Label (text.ToString());
	}
}
