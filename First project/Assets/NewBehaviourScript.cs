using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public GameObject gameObject;
    public int shag;
    // Start is called before the first frame update
    void Start()
    {
        gameObject = GameObject.Find("Sphere");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            float x = gameObject.transform.position.x;
            float y = gameObject.transform.position.y;
            float z = gameObject.transform.position.z;
            gameObject.transform.position = new Vector3(x, y, z + shag);
        }
        if (Input.GetKeyDown(KeyCode.S))
        { 
            float x = gameObject.transform.position.x;
            float y = gameObject.transform.position.y;
            float z = gameObject.transform.position.z;
            gameObject.transform.position = new Vector3(x, y, z - shag);
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            float x = gameObject.transform.rotation.x;
            float y = gameObject.transform.rotation.y;
            float z = gameObject.transform.rotation.z;
            float w = gameObject.transform.rotation.w;
            gameObject.transform.Rotate(x, y + 0.3F, z);
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            float x = gameObject.transform.rotation.x;
            float y = gameObject.transform.rotation.y;
            float z = gameObject.transform.rotation.z;
            float w = gameObject.transform.rotation.w;
            gameObject.transform.Rotate(x, y - 0.3F, z);
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            float x = gameObject.transform.position.x;
            float y = gameObject.transform.position.y;
            float z = gameObject.transform.position.z;
            gameObject.transform.position = new Vector3(x, y + shag, z);
        }
        if (Input.GetKeyDown(KeyCode.LeftControl))
        {
            float x = gameObject.transform.localScale.x;
            float y = gameObject.transform.localScale.y;
            float z = gameObject.transform.localScale.z;
            gameObject.transform.localScale = new Vector3(x, y / 2, z);
        }    
        if (Input.GetKeyUp(KeyCode.LeftControl))
        {
            float x = gameObject.transform.localScale.x;
            float y = gameObject.transform.localScale.y;
            float z = gameObject.transform.localScale.z;
            gameObject.transform.localScale = new Vector3(x, y * 2, z);
        }
    }
}
