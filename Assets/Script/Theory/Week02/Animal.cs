using System;
using UnityEngine;

public class Animal : MonoBehaviour
{
    public string Name = "";
    public float Health;
    public int Age;

    // Constructor �ͧ Base Class
    public Animal(string name, int age)
    {
        Name = name;
        Age = age;
        Health = 100.0f; // ��������آ�Ҿ��� 100
        Debug.Log($"A new animal named {Name} was created.");
    }
    
    public void Eat(string food) // ���ʹ�������١���׺�ʹ�
    {
        if (food != string.Empty)
        {
            Health += 10.0f;
            Debug.Log($"{Name} is eating {food}.");
        }
        else
        {
            Health -= 10.0f;
            Debug.Log($"{Name} has nothing to eat.");
        }
        Health = Mathf.Clamp(Health, 0, 100.0f); // �Թ�����آ�Ҿ������� ������Թ 100

    }

    // ���ʹ�����������١���¹��������´��������§�ͧ
    // �� virtual �����������١����ö Override ��
    public virtual void MakeSound()
    {
        Debug.Log($"{Name} makes a generic sound.");
    }
    

    
}
