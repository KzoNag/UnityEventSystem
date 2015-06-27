﻿using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using System.Collections;

public class InputReceiver : InputBehaviour
{	
	public override void OnPointerEnter (PointerEventData eventData)
	{
		base.OnPointerEnter (eventData);
		SetColor (Color.red);
	}

	public override void OnPointerExit (PointerEventData eventData)
	{
		base.OnPointerExit (eventData);
		SetColor (Color.white);
	}
	
	public override void OnDrag (PointerEventData eventData)
	{
		base.OnDrag (eventData);
		SetPosition (eventData);
	}

	void SetPosition(PointerEventData eventData)
	{
		var rect = transform as RectTransform;
		if (rect) 
		{
			rect.anchoredPosition = eventData.position;
		}
		else
		{
			transform.position = (Vector2)eventData.pointerCurrentRaycast.worldPosition;
		}
	}

	void SetColor(Color color)
	{
		var renderer = GetComponent<Renderer> ();
		if (renderer) 
		{
			renderer.material.color = color;
		}

		var image = GetComponent<Image> ();
		if (image) 
		{
			image.color = color;
		}
	}
}
