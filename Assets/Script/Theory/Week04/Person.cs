using System;
using UnityEngine;

public class Person : MonoBehaviour
{
    // C# �����ҧ private field ���� backing field ������ѵ��ѵ�
    //1. Auto-Implemented Property
    public string FirstName;
    public string LastName;
    public double HeightInMeters { get; set; }
    public double WeightInKg { get; set; }
    //2. Full Property (�ٻẺ���) ���ٻẺ�������ó����ش ���������Ѻ����ͤس��ͧ��äǺ��������Ҷ֧���������ҧ�����´
    private int _heartRate; // private field
    public int HeartRate // public property
    {
        get
        {
            return _heartRate; // ��ҹ��Ҩҡ _age
        }
        set
        {
            // Logic ��õ�Ǩ�ͺ: ��Ǩ�ͺ��Ҥ�ҷ���Ѻ�� (value) ����Թ��˹�
            if (value >= 60 && value <= 250)
            {
                Debug.Log("HeartRate is set " + value);
                _heartRate = value; // ��˹������� _age
            }
            else
            {
                Debug.Log("HeartRate should be 60 - 250.");
            }
        }
    }

    //3. Property Ẻ Read-Only (��ҹ�����ҧ����)
    //�Ըշ�� 1: �� public get; private set;
    public string IdCardNumber { get; private set; }
    //�Ըշ�� 2: �� public get; ���ҧ����
    public DateTime BrithDay { get; }
    public int Age
    {
        get {
            int _age = DateTime.Today.Year - BrithDay.Year;
            return _age; // Read-only property
        }
    }
    public double Bmi => WeightInKg / (HeightInMeters * HeightInMeters); // Read-only property
    public Person(string idCardNumber, DateTime brithDay)
    {
        IdCardNumber = idCardNumber;
        BrithDay = brithDay;
    }
    //4. Property Ẻ Write-Only (��¹�����ҧ����)
    private string _password;

    public string Password
    {
        set
        {
            if (value.Length >= 8)
            {
                _password = value;
                Debug.Log("Password set successfully.");
            }
            else
            {
                Debug.Log("Password must be at least 8 characters long.");
            }
        }
    }
    //5. Protected Property (����Ѻ���ʷ���׺�ʹ��ҹ��)
    private int _employeeId;

    public int EmployeeId
    {
        get
        {
            return _employeeId;
        }
        protected set
        {
            _employeeId = value;
        }
    }
}
