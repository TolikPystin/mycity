using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarMoving : MonoBehaviour
{
    public float speed = 23f; // модификатор public делает переменную доступной в инспектере и из других скриптов
    private float maxSpeed = 120f;
    private float acceleration = 20f; // ускорение
    private float deceleration = 10f; // торможение
    private float maxreverseSpeed = -15f; 
    private float rotationSpeed = 100f; // int тип данных с целыми числами, float тип данных с дробной частью
    public float vertical;
    public float horizontal; 
    void Start()
    {
        Debug.Log("welcome to my sity");
    }


    void Update()

    {
        vertical = Input.GetAxis("Vertical");
        horizontal = Input.GetAxis("Horizontal");

        transform.Translate(Vector3.forward * speed * Time.deltaTime*vertical);
        transform.Rotate(Vector3.up*rotationSpeed*Time.deltaTime*horizontal);

        // transform.position += new Vector3(0, 0, 1) * Time.deltaTime * speed;
        //if (Input.GetKey(KeyCode.W))
        //{
        //    transform.Translate(Vector3.forward * speed * Time.deltaTime);
        //}
        //if (Input.GetKey(KeyCode.S))
        //{
        //    transform.Translate(Vector3.back * speed * Time.deltaTime);
        //}
    }
}
