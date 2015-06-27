using UnityEngine;
using System.Collections;

public class CustomEventReceiver : MonoBehaviour, ICustomEventHandler
{

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void OnReceiveEvent (CustomEventData eventData)
	{
		Debug.Log (string.Format("[CustomEventReceiver]{0} : {1}", name, eventData.message));
	}
}
