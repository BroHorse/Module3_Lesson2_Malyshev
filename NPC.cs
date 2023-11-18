using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;

public class NPC : MonoBehaviour
{
    //Создание переменой жизни
    public int health = 5;
    //Создание переменой уровня
    public int level = 2;
    //Создание переменой скорости
    public float speed = 1.3f;


    // Start is called before the first frame update
    void Start()
    {//Обновление жизне й
        health += level;
        //Ввод даныных о коллиестве жизней
        print("Колличество Жизней:* + health");
    }

    // Update is called once per frame
    void Update()
    {
        // Структура данных, которая получает позицию игрока
        Vector3 newPosition = transform.position;
        // Находим координаты объекта спустя 1 кадр
        newPosition.z+=speed * Time.deltaTime;
        transform.position=newPosition;
    }
}
