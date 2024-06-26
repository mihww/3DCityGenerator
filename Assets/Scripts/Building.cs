using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Building : MonoBehaviour
{
    private Animator anim;

	private void Start()
	{
		anim = GetComponent<Animator>();
		anim.speed = Random.Range(0.5f, 1.5f);
	}
}
