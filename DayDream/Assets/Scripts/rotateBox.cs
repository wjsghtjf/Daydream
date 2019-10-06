using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotateBox : MonoBehaviour {
    //휴대폰을 회전시키는데 사용되었습니다
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.Rotate(new Vector3(0, 0, 5));
       
		
	}
}
