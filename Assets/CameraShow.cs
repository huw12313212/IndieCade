using UnityEngine;
using System.Collections;

public class CameraShow : MonoBehaviour {

	public Vector2 resolution;
	public Camera screenCamera;

	private RenderTexture texture;
	private Material material;

	// Use this for initialization
	void Start () {
		material = renderer.material;
		texture = new RenderTexture ((int)resolution.x, (int)resolution.y,0);
		material.mainTexture = texture;
		screenCamera.targetTexture = texture;

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
