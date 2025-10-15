using System;
using UnityEngine;

public abstract class Food : MonoBehaviour
{
    // �س���ѵԷ������÷ء��Դ��
    public string Name;
    public double Price;

    // �͹ʵ�ѡ��������Ѻ�������
    public Food(string name, double price)
    {
        Name = name;
        Price = price;
    }

    // Abstract Method: �ĵԡ�������ͧ�������١��¹���ͧ
    // ����� "�ѭ��" �������÷ء��Դ��ͧ���Ը����������Ѻ��зҹ
    public abstract void Prepare();
    public abstract void Eat();

    // ���ʹ���Է�����鴡�÷ӧҹ��������
    public void DisplayInfo()
    {
        Debug.Log($"--- Food Info ---");
        Debug.Log($"Name: {Name}");
        Debug.Log($"Calories: {Price} kcal");
    }

}
