using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarMoving : MonoBehaviour
{
    public float speed = 23f; // ����������� public ������ ���������� ��������� � ���������� � �� ������ ��������
    private float maxSpeed = 120f;
    private float acceleration = 20f; // ���������
    private float deceleration = 10f; // ����������
    private float maxreverseSpeed = -15f;
    private float rotationSpeed = 100f; // int ��� ������ � ������ �������, float ��� ������ � ������� ������
    public float vertical;
    public float horizontal;
    public Vector3 startposition;
    public Quaternion startrotation;
    void Start() 
    {
        startposition = transform.position;
        startrotation = transform.rotation;
        Debug.Log("welcome to my sity");
    }


    void Update()

    {
        vertical = Input.GetAxis("Vertical");
        horizontal = Input.GetAxis("Horizontal");

        transform.Translate(Vector3.forward * speed * Time.deltaTime * vertical);
        transform.Rotate(Vector3.up * rotationSpeed * Time.deltaTime * horizontal);

        if (Outoffbounds())
        {
            Resettostartposition();
        }
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

    bool Outoffbounds()
    {
        if (transform.position.y < -2 || transform.position.y > 20)
        { return true; }
        else
        {
            return false;
        }
    }
    public void Resettostartposition()
    {
        transform.position = startposition;
        transform.rotation = startrotation;
            
    }
}
