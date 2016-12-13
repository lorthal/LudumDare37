using UnityEngine;
using System.Collections.Generic;

public class BookRotator : MonoBehaviour {
    [SerializeField]
    Vector2 randomScale;

    List<float> rotations;

    void Start()
    {
        rotations = new List<float>();
        for (int i = 0; i < 3; i++)
        {
            rotations.Add(Random.Range(randomScale.x, randomScale.y));
        }
        
    }

	void Update () {
        transform.Rotate(rotations[0], rotations[1], rotations[2]);
        //transform.rotation = Quaternion.Lerp(transform.rotation, new Quaternion(transform.rotation.x + rotations[0], transform.rotation.y + rotations[1], transform.rotation.z + rotations[2], transform.rotation.w + rotations[3]), Time.deltaTime * rotations[4]);
	}
}
