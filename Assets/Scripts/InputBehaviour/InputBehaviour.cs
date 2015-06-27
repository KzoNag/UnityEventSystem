using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

using System.Collections;

public class InputBehaviour : MonoBehaviour,
							IPointerEnterHandler,
							IPointerExitHandler,
							IPointerDownHandler,
							IPointerUpHandler,
							IPointerClickHandler,
							IBeginDragHandler,
							IEndDragHandler,
							IDragHandler,
							IDropHandler
{
	[System.Serializable]
	public class PointerEvent : UnityEvent<PointerEventData>{}

	[System.Serializable]
	public class EventHandler
	{
		public PointerEvent onPointerEnter;
		public PointerEvent onPointerExit;
		public PointerEvent onPointerDown;
		public PointerEvent onPointerUp;
		public PointerEvent onPointerClick;
		public PointerEvent onBeginDrag;
		public PointerEvent onEndDrag;
		public PointerEvent onDrag;
		public PointerEvent onDrop;
	}

	[SerializeField]
	private EventHandler eventHandler;

	public virtual void OnPointerEnter(PointerEventData eventData)
	{
		Debug.Log (string.Format("{0}:OnPointerEnter", name));
		eventHandler.onPointerEnter.Invoke (eventData);
	}

	public virtual void OnPointerExit(PointerEventData eventData)
	{
		Debug.Log (string.Format("{0}:OnPointerExit", name));
		eventHandler.onPointerExit.Invoke (eventData);
	}

	public virtual void OnPointerDown(PointerEventData eventData)
	{
		Debug.Log (string.Format("{0}:OnPointerDown", name));
		eventHandler.onPointerDown.Invoke (eventData);
	}

	public virtual void OnPointerUp(PointerEventData eventData)
	{
		Debug.Log (string.Format("{0}:OnPointerUp", name));
		eventHandler.onPointerUp.Invoke (eventData);
	}

	public virtual void OnPointerClick(PointerEventData eventData)
	{
		Debug.Log (string.Format("{0}:OnPointerClick", name));
		eventHandler.onPointerClick.Invoke (eventData);
	}

	public virtual void OnBeginDrag(PointerEventData eventData)
	{
		Debug.Log (string.Format("{0}:OnBeginDrag", name));
		eventHandler.onBeginDrag.Invoke (eventData);
	}

	public virtual void OnEndDrag(PointerEventData eventData)
	{
		Debug.Log (string.Format("{0}:OnEndDrag", name));
		eventHandler.onEndDrag.Invoke (eventData);
	}

	public virtual void OnDrag(PointerEventData eventData)
	{
		Debug.Log (string.Format("{0}:OnDrag", name));
		eventHandler.onDrag.Invoke (eventData);
	}

	public virtual void OnDrop(PointerEventData eventData)
	{
		Debug.Log (string.Format("{0}:OnDrop", name));
		eventHandler.onDrop.Invoke (eventData);
	}
}
