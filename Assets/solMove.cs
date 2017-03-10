using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class solMove : MonoBehaviour {
    public GameObject lala;
	// Use this for initialization
	void Start () {
        iTween.MoveTo(lala, iTween.Hash("path", iTweenPath.GetPath("New Path 3"),"time",15f,"easetype",iTween.EaseType.easeInOutSine,"looptype","loop"));
		
	}
	
	// Update is called once per frame
	void Update () {
	}
}
