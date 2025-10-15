using System;
using System.Collections.Generic;
using UnityEngine;

public class FoodGenerator : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // ���ҧ��ʵ�ͧ Food
        List<Food> Order = new List<Food>();
        // ���� Pizza ��� Burger �������ʵ�
        //Food food = new Food(); �������ö���ҧ object �ͧ���� Food ���µç �����繤��� abstract

        Order.Add(new Burger(true, 550));
        List<string> pizzaToppings = new List<string> { "Pepperoni", "Mushrooms", "Onions" };
        Order.Add(new Pizza("Pepperoni", 600, "L", pizzaToppings));

        // ǹ�ٻ���ͨѴ��áѺ��������Ъ�Դ
        foreach (Food item in Order)
        {
            item.DisplayInfo();
            item.Prepare();
            item.Eat();
        }
    }

    
}
