using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPoolFountain : MonoBehaviour {

    public GameObject prefab;
    public float spawnDelay;

	// Use this for initialization
	void Start () {
        StartCoroutine(SpawnObject());
	}
	
	// Update is called once per frame
	void Update () {

        
	}

    IEnumerator SpawnObject()
    {
        while (true)
        {
            yield return new WaitForSeconds(spawnDelay);

            GameObject fountainObj = ObjectPoolManager.GetObject(prefab);
            Rigidbody rb = fountainObj.GetComponent<Rigidbody>();

            rb.AddForce(new Vector3(0, 300, 0));

            
        }
    }
}
