using UnityEngine;
using System.Collections;

public class Fractal : MonoBehaviour {
	public Mesh mesh;
	public Material material;
	public int maxDepth;
	public int depth;

	private void Start() {
		gameObject.AddComponent<MeshFilter>().mesh = mesh;
		gameObject.AddComponent<MeshRenderer>().material = material;

		if (depth < maxDepth) {
			new GameObject ("Fractal Child").AddComponent<Fractal>().Initialize(this);	
		}
		 
	}

	private void Initialize(Fractal parent) {
		mesh = parent.mesh;
		material = parent.material;
		maxDepth = parent.maxDepth;
		depth = parent.depth + 1;
		transform.parent = parent.transform;
	}
}
