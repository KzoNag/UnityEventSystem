using UnityEngine;
using UnityEngine.EventSystems;

using System.Collections;

public class CustomEventSender : MonoBehaviour
{
	public GameObject receiver;
	public string message = "Message!!";

	// Use this for initialization
	void Start () 
	{

	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnGUI()
	{
		var eventData = new CustomEventData (EventSystem.current) 
		{
			message = this.message
		};

		if (GUILayout.Button ("EventSystem")) 
		{
			ExecuteEvents.Execute<ICustomEventHandler> (receiver, eventData, (_handler, _eventData) => { _handler.OnReceiveEvent((CustomEventData)_eventData); });
			//ExecuteEvents.Execute<ICustomEventHandler> (receiver, eventData, CustomEventHandler.Execute);
			//ExecuteEvents.ExecuteHierarchy<ICustomEventHandler> (receiver, eventData, CustomEventHandler.Execute);
		}
		if (GUILayout.Button ("SendMessage")) 
		{
			receiver.SendMessage ("OnReceiveEvent", eventData);
			//receiver.SendMessageUpwards ("OnReceiveEvent", eventData);
		}
	}
}
