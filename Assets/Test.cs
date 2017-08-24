using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour {

    void Awake()
    {
        print("FrameCount When Awaking: " + Time.frameCount);
        print(gameObject.name + "Awake");
    }

    void OnEnable()
    {
        print(gameObject.name + "OnEnable");
    }


	void Start () {
        print("FrameCount When Starting: " + Time.frameCount);
        print(gameObject.name + "Start");
	}

	
	// Update is called once per frame
	void Update () {
		
	}
}
