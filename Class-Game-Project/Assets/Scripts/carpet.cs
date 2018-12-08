using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class carpet : MonoBehaviour {
	private Rigidbody2D rigidbody;
	private Vector3 posA;
	private Vector3 posB;
	
	private Vector3 nextpos;
	[SerializeField]
	private float speed;
	[SerializeField]
	private Transform childtransform;
	[SerializeField]
	private Transform transformB;
	


	// Use this for initialization
	void Start () {
		posA=childtransform.localPosition;
		posB=transformB.localPosition;
		nextpos=posB;
	}
	
	// Update is called once per frame
	void Update () {
		
		Move();
	}
	
	private void Move(){
		childtransform.localPosition=Vector3.MoveTowards(childtransform.localPosition, nextpos,speed*Time.deltaTime);
		if(Vector3.Distance(childtransform.localPosition, nextpos)<=0.1){
			
			ChangeDestination();
			changeScale();
			
		}
	}
	
	private void changeScale(){
		Vector2 newScale = childtransform.gameObject.transform.localScale;
		newScale.x *= -1;
		childtransform.gameObject.transform.localScale = newScale;
		

	}
	private void ChangeDestination(){
		nextpos= nextpos!=posA ? posA:posB;
		
	}

}
