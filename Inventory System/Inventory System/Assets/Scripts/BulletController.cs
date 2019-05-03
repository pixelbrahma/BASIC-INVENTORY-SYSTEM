using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour {

    [SerializeField] private float bulletSpeed;
    private Rigidbody2D rb;

	void Start () {
        rb = GetComponent<Rigidbody2D>();
        Destroy(this.gameObject, 4.0f);
	}
	
	void Update () {
        rb.velocity = Vector2.up * bulletSpeed;
	}
}
