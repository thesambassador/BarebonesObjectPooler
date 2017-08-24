using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColorOnEnable : MonoBehaviour {

    private static Color[] _colors;
    private MeshRenderer _renderer;

	// Use this for initialization
    void Awake()
    {
        _renderer = GetComponent<MeshRenderer>();
        if (_colors == null)
        {
            _colors = new Color[5];
            _colors[0] = Color.red;
            _colors[1] = Color.blue;
            _colors[2] = Color.green;
            _colors[3] = Color.cyan;
            _colors[4] = Color.magenta;
        }
    }

    void OnEnable()
    {
        _renderer.material.color = GetRandomColor();
    }

    public Color GetRandomColor()
    {
        return _colors[Random.Range(0, _colors.Length)];
    }
}
