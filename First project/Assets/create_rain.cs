using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class create_rain : MonoBehaviour
{
    public GameObject kaplya;
    public int size_mass_rain;
    public int kol_rain;
    public GameObject Хуй;
    private float x;
    private float y;
    private float z;

    // Start is called before the first frame update
    void Start()
    {
        x = Хуй.transform.position.x;
        y = Хуй.transform.position.y;
        z = Хуй.transform.position.z;
    }

    // Update is called once per frame
    void Update()
    {
        if (kol_rain <= size_mass_rain)
        {
            for (int i = 0; i < 10; i++)
            {
                Instantiate(kaplya, new Vector3(x, y, z), kaplya.transform.rotation);
            }
            kol_rain+=10;
        }
    }
}
