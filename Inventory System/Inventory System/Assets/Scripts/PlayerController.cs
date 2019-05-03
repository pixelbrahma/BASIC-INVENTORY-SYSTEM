using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
    [SerializeField] private Transform pistolPrefab;
    [SerializeField] private Transform gunPrefab;
    [SerializeField] private Transform grenadePrefab;
    [SerializeField] GameObject invent1;
    [SerializeField] GameObject invent2;
    [SerializeField] GameObject invent3;
    [SerializeField] private Transform pistolBulletPrefab;
    [SerializeField] private Transform gunBulletPrefab;
    [SerializeField] private Transform grenadeBulletPrefab;
    private float selectedChioce = 0;
    private Transform muzzle = null;
    private int gunSelect = 0;
    [SerializeField] private float offset;

    private Rigidbody2D rb;
    [SerializeField] private float moveSpeed;

	void Start () {
        rb = GetComponent<Rigidbody2D>();
	}
	
	void Update () {
        float movement = Input.GetAxisRaw("Horizontal");
        rb.velocity = Vector2.right * movement * moveSpeed;
        if(Input.GetKeyDown(KeyCode.Alpha1))
        {
            selectedChioce = 1;
            WeaponSpawn();
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            selectedChioce = 2;
            WeaponSpawn();
        }
        else if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            selectedChioce = 3;
            WeaponSpawn();
        }
        else if(Input.GetKeyDown(KeyCode.Space))
        {
            Shoot();
        }
    }

    void WeaponSpawn()
    {
        if(muzzle == null)
        {
             Weapons();
        }
        else
        {
            Destroy(muzzle.gameObject);
            gunSelect = 0;
            Weapons();
        }
    }

    void Weapons()
    {
        if (selectedChioce == 1)
        {
            if (invent1.transform.GetChild(0).name == "Pistol")
            {
                muzzle = Instantiate(pistolPrefab, transform.position, Quaternion.identity);
                muzzle.parent = transform;
                gunSelect = 1;
            }
            else if (invent1.transform.GetChild(0).name == "Gun")
            {
                muzzle = Instantiate(gunPrefab, transform.position, Quaternion.identity);
                muzzle.parent = transform;
                gunSelect = 2;
            }
            else if (invent1.transform.GetChild(0).name == "Grenade")
            {
                muzzle = Instantiate(grenadePrefab, transform.position, Quaternion.identity);
                muzzle.parent = transform;
                gunSelect = 3;
            }
        }
        if (selectedChioce == 2)
        {
            if (invent2.transform.GetChild(0).name == "Pistol")
            {
                muzzle = Instantiate(pistolPrefab, transform.position, Quaternion.identity);
                muzzle.parent = transform;
                gunSelect = 1;
            }
            else if (invent2.transform.GetChild(0).name == "Gun")
            {
                muzzle = Instantiate(gunPrefab, transform.position, Quaternion.identity);
                muzzle.parent = transform;
                gunSelect = 2;
            }
            else if (invent2.transform.GetChild(0).name == "Grenade")
            {
                muzzle = Instantiate(grenadePrefab, transform.position, Quaternion.identity);
                muzzle.parent = transform;
                gunSelect = 3;
            }
        }
        if (selectedChioce == 3)
        {
            if (invent3.transform.GetChild(0).name == "Pistol")
            {
                muzzle = Instantiate(pistolPrefab, transform.position, Quaternion.identity);
                muzzle.parent = transform;
                gunSelect = 1;
            }
            else if (invent3.transform.GetChild(0).name == "Gun")
            {
                muzzle = Instantiate(gunPrefab, transform.position, Quaternion.identity);
                muzzle.parent = transform;
                gunSelect = 2;
            }
            else if (invent3.transform.GetChild(0).name == "Grenade")
            {
                muzzle = Instantiate(grenadePrefab, transform.position, Quaternion.identity);
                muzzle.parent = transform;
                gunSelect = 3;
            }
        }
    }

    void Shoot()
    {
        if(gunSelect == 1)
        {
            Vector3 position = new Vector3(transform.position.x, transform.position.y + offset, 0f);

            Transform bullet = Instantiate(pistolBulletPrefab, position, Quaternion.identity);
        }
        else if (gunSelect == 2)
        {
            Vector3 position = new Vector3(transform.position.x, transform.position.y + offset, 0f);

            Transform bullet = Instantiate(gunBulletPrefab, position, Quaternion.identity);
        }
        else if (gunSelect == 3)
        {
            Vector3 position = new Vector3(transform.position.x, transform.position.y + offset, 0f);

            Transform bullet = Instantiate(grenadeBulletPrefab, position, Quaternion.identity);
        }
    }
}
