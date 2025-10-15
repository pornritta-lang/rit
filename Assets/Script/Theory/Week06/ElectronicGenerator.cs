using System;
using System.Collections.Generic;
using UnityEngine;

public class ElectronicGenerator : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // 1. ������ҧ����� Polymorphism ��ҹ ISwitchControl
        // ���ҧ List �ͧ�ػ�ó�������ö�Դ/�Դ��
        LightBulb lightBulb = new LightBulb();
        lightBulb.TurnOn();
        lightBulb.TurnOff();
        Debug.Log(lightBulb.isOn);

        PortableFan fan = new PortableFan();
        fan.TurnOff();
        fan.TurnOn();
        fan.TurnOn();
        fan.TurnOn();
        fan.TurnOn();
        Debug.Log(fan.isOn);


        List<ISwitchControl> switchableDevices = new List<ISwitchControl>();

        // ���� AirConditioner ��� lightBulb ����� List (�� Reference �� ISwitchControl)
        switchableDevices.Add(lightBulb);
        switchableDevices.Add(fan);

        Debug.Log("--- 1. ��÷ӧҹ�����ѹ��ҹ ISwitchControl (�Դ/�Դ) ---");

        foreach (var device in switchableDevices)
        {
            // ����ö���¡�� TurnOn ��Ѻ�ء Object � List
            device.TurnOn();
        }

        Debug.Log("\n--- ��觻Դ������ ---");
        foreach (var device in switchableDevices)
        {
            device.TurnOff();
        }
    }

}
