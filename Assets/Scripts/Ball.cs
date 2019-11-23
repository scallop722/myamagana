using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public GameObject cube;

    // Start is called before the first frame update
    void Start()
    {
        cube.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        var position = transform.position;
        if (position.y < -100) {
            transform.position = new Vector3(2, 20, 2);
            transform.rotation = Quaternion.identity;
            transform.Rotate(0, 0, 0);
            
            var rb = GetComponent<Rigidbody>();
            rb.velocity = Vector3.zero;
            rb.angularVelocity = Vector3.zero;
        }
    }

    void OnTriggerEnter(Collider other) {
        Debug.Log(other.gameObject.name);
        Debug.Log(other.gameObject.tag);
        if (other.gameObject.name == "Goal") {
            
            
            cube.SetActive(true);
            for (int i = 0; i < 1000; i++) {
                Instantiate(cube);
            }
        }
    }
}
