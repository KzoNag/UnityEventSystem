﻿using UnityEngine;
using UnityEngine.EventSystems;

using System.Collections;

public class PointerEventReceiver : MonoBehaviour, IPointerClickHandler 
{

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void OnPointerClick(PointerEventData eventData)
	{
		transform.localScale *= 1.1f;
	}
}
