using UnityEngine;
using System.Collections;

public class bookRandColor : MonoBehaviour {

	public Material mat1;
    public Material mat2;
    public Material mat3;
    public Material mat4;
    public Material mat5;
    public Material mat6;
	public Material mat7;
	// Use this for initialization
	void Start () {
		int x;
		x = Random.Range(0, 7);
		switch (x)
            {
                case 0: GetComponent<Renderer>().material = mat1; break;
                case 1: GetComponent<Renderer>().material = mat2; break;
                case 2: GetComponent<Renderer>().material = mat3; break;
                case 3: GetComponent<Renderer>().material = mat4; break;
                case 4: GetComponent<Renderer>().material = mat5; break;
                case 5: GetComponent<Renderer>().material = mat6; break;
				case 6: GetComponent<Renderer>().material = mat7; break;
        }
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
