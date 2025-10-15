using System;
using System.Collections.Generic;
using UnityEngine;

public class Pizza : Food
{
    public string Size { get; set; } // Small, Medium, Large
    public List<string> Toppings { get; set; }
    public Pizza(string name, double price, string size, List<string> toppings)
        : base(name, price) // ���¡�͹ʵ�ѡ����ͧ�������
    {
        Size = size;
        Toppings = toppings;
    }
    public override void Prepare()
    {
        Debug.Log($"Preparing a {Size} pizza named {Name} with toppings: {string.Join(", ", Toppings)}.");
        // �鴡���������, ���, ���, ��з�ͻ��駵�ҧ�
    }
    public override void Eat()
    {
        Debug.Log($"Eating the delicious {Name} pizza!");
        // �鴡�áԹ�ԫ���
    }
}
