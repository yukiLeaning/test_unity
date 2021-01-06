using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallControl : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("forward x=" + this.transform.forward.x);
        Debug.Log("forward y=" + this.transform.forward.y);
        Debug.Log("forward z=" + this.transform.forward.z);
        if (Input.GetKey(KeyCode.Space) && (this.transform.forward.x == 0) && (this.transform.forward.y == 0) && (this.transform.forward.z == 0))
        {
            this.transform.eulerAngles = new Vector3(0, Random.Range(30, 120), 0);
            this.gameObject.GetComponent<Rigidbody>().AddForce(transform.forward * 500);
        }
    }
}
