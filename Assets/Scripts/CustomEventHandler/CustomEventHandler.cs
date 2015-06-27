using UnityEngine;
using UnityEngine.EventSystems;

using System.Collections;

public class CustomEventData : BaseEventData
{
	public string message;

	public CustomEventData(EventSystem eventSystem) : base(eventSystem)
	{
	}
}

public interface ICustomEventHandler : IEventSystemHandler
{
	void OnReceiveEvent (CustomEventData eventData);
}

public static class CustomEventHandler
{
	public static void Execute(ICustomEventHandler handler, BaseEventData eventData)
	{
		handler.OnReceiveEvent (ExecuteEvents.ValidateEventData<CustomEventData>(eventData));
	}
}
