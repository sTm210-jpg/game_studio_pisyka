using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class create_trees : MonoBehaviour
{
    public GameObject panel;
    public int size;
    public int max_mocha;
    public int mocha_num;

    // Start is called before the first frame update
    void Start()
    {
        panel = GameObject.Find("Платформа");
    }

    // Update is called once per frame
    void Update()
    {
        System.Random random = new System.Random();
        float x = random.Next(-200, 200);
        float z = random.Next(-200, 200); 
        float hz = random.Next(-200, 200); 
        Instantiate(panel, new Vector3(x, 200, z), panel.transform.rotation);
        mocha_num++;

        if (mocha_num >= max_mocha)
        {
            Destroy(GameObject.Find("Платформа(Clone)"));
            mocha_num--;
        }
    }
}
