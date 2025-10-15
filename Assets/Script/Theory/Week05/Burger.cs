using System;
using UnityEngine;

public class Burger : Food
{
    public bool HasCheese { get; set; }

    // ���¡�͹ʵ�ѡ����ͧ�������
    public Burger(bool hasCheese, double price) : base("Burger", price)
    {
        HasCheese = hasCheese;
    }

    // Override ���ʹ Prepare() ��� Eat()
    public override void Prepare()
    {
        string cheeseStatus = HasCheese ? "with cheese" : "without cheese";
        Debug.Log($"Assembling a Burger {cheeseStatus}.");
        Debug.Log("Patty is grilled, and buns are toasted.");
    }

    public override void Eat()
    {
        Debug.Log("Taking a big bite of the burger!");
    }
}
