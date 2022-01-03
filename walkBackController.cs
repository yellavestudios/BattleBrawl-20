using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class walkBackController : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
	
	public void OnPointerDown (PointerEventData data){
		
		fightController.mvBack = true;
	}
	
	
	


	public void OnPointerUp (PointerEventData data){
	
	fightController.mvBack = false;
}


}
