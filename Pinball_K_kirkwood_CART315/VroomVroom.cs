using UnityEngine;
using System.Collections;
using UnityEngine.AI;

public float topSpeed = 80;
private float currentSpeed = 0;
private float pitch = 0;

public class VroomVroom : MonoBehaviour
{
	public VroomVroom()
	{
	}
}

void Update()
{
    currentSpeed = transform.GetComponent<Rigidbody>().velocity.magnitude * 3.6f;
    pitch = currentSpeed / topSpeed;

    transform.GetComponent <AudioSource>().Pitch = pitch;
}