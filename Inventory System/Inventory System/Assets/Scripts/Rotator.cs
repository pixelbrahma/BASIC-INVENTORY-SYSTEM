using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour {

    [SerializeField] private float rotationSpeed;
    [SerializeField] GameObject invent1;
    [SerializeField] GameObject invent2;
    [SerializeField] GameObject invent3;
    private static int gunCount = 0;

	void Start () {
		
	}
	
	void Update () {
        transform.Rotate(0f, 0f, rotationSpeed);
        if(gunCount == 3)
        {
            Destroy(this);
        }
	}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Player")
        {
            if(gunCount == 0)
            {
                Vector3 position = invent1.transform.position;
                transform.position = new Vector3(position.x, position.y, position.z - 2);
                transform.rotation = Quaternion.Euler(0f, 0f, 0f);
                rotationSpeed = 0f;
                transform.parent = invent1.transform;
                gunCount++;
            }
            else if(gunCount == 1)
            {
                Vector3 position = invent2.transform.position;
                transform.position = new Vector3(position.x, position.y, position.z - 2);
                transform.rotation = Quaternion.Euler(0f, 0f, 0f);
                rotationSpeed = 0f;
                transform.parent = invent2.transform;
                gunCount++;
            }
            else if(gunCount == 2)
            {
                Vector3 position = invent3.transform.position;
                transform.position = new Vector3(position.x, position.y, position.z - 2);
                transform.rotation = Quaternion.Euler(0f, 0f, 0f);
                rotationSpeed = 0f;
                transform.parent = invent3.transform;
                gunCount++;
            }
        }
    }
}
