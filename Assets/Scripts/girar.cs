using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class girar : MonoBehaviour
{
    public Transform target;
    public float speed;
    public float eixoX;
    public float eixoY;
    public float eixoZ;

    void Start()
    {
        if (target == null)
        {
            target = gameObject.transform;
            Debug.Log(message: "Alvo não definido.");
        }
    }


    void Update()
    {
        transform.RotateAround(target.position, new Vector3(eixoX, eixoY, eixoZ), speed * Time.deltaTime);

    }
}

