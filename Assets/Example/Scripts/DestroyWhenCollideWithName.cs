using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyWhenCollideWithName : MonoBehaviour {

    public string Name = "Ground";

    void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.gameObject.name == "Ground")
        {
            ObjectPoolManager.ReturnObject(this.gameObject);
        }
    }
}
