using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;

public class NPC : MonoBehaviour
{
    //�������� ��������� �����
    public int health = 5;
    //�������� ��������� ������
    public int level = 2;
    //�������� ��������� ��������
    public float speed = 1.3f;


    // Start is called before the first frame update
    void Start()
    {//���������� ����� �
        health += level;
        //���� ������� � ���������� ������
        print("����������� ������:* + health");
    }

    // Update is called once per frame
    void Update()
    {
        // ��������� ������, ������� �������� ������� ������
        Vector3 newPosition = transform.position;
        // ������� ���������� ������� ������ 1 ����
        newPosition.z+=speed * Time.deltaTime;
        transform.position=newPosition;
    }
}
