using System;
using UnityEngine;

public class PersonGenerator : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("--- Creating a new Person object ---");
        // ���ҧ Object �ͧ Person ���� constructor
        // ��ͧ����� IdCardNumber ��� HeightInMeters ����
        DateTime BirthDay= new DateTime(1991, 1, 1);
        Person p1 = new Person("1103700012345", BirthDay);

        // 1. Auto-Implemented Property: FirstName, LastName
        // ��駤�Ҫ�����й��ʡ��
        p1.FirstName = "John";
        p1.LastName = "Doe";


        Debug.Log($"Name set to: {p1.FirstName} {p1.LastName}");

        Debug.Log("--- Setting Properties ---");
        // 2. Full Property: HeartRate
        // ��駤�����ط��١��ͧ
        p1.HeartRate = 60;
        Debug.Log($"HeartRate set successfully: {p1.HeartRate}");
        // �ͧ��駤�����ط��Դ��Ҵ (���ʴ���ͤ�����͹)
        p1.HeartRate = -5;

        // 3. Read-Only Properties: IdCardNumber, HeightInMeters, Bmi
        // IdCardNumber ��� HeightInMeters �١��駤�ҵ͹���ҧ Object ����
        Debug.Log($"\n--- Accessing Read-Only Properties ---");
        Debug.Log($"ID Card Number: {p1.IdCardNumber}");
        Debug.Log($"Age: {p1.Age:F2} m");

        // ��˹���� WeightInKg ������� Bmi �ӹǳ��
        p1.HeightInMeters = 1.75;
        p1.WeightInKg = 70.0;

        Debug.Log($"Weight: {p1.WeightInKg:F1} kg");
        // Bmi �� Read-Only ��Фӹǳ�ҡ��� Weight ��� Height
        Debug.Log($"BMI: {p1.Bmi:F2}");

        // �ͧ��������䢤�� Read-Only (���Դ Compile Error)
        // p1.IdCardNumber = "9999999999999"; // ERROR!
        // p1.HeightInMeters = 1.80; // ERROR!

        // 4. Write-Only Property: Password
        Debug.Log("\n--- Setting Write-Only Property ---");
        // ��駤�����ʼ�ҹ���١��ͧ (������� 8 ����ѡ�â���)
        p1.Password = "strong_password123";
        // �ͧ��駤�����ʼ�ҹ�������Թ�
        p1.Password = "short";

        // �ͧ��������ҹ������ʼ�ҹ��Ѻ�� (���Դ Compile Error)
        // string password = p1.Password; // ERROR!
    }
}
