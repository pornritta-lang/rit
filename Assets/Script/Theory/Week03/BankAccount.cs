using System;
using UnityEngine;

public class BankAccount 
{
    // public: ��Ҷ֧��ҡ�ء��� (�Ţ���ѭ���Ҹ�ó�)
    public string AccountNumber;

    // protected: ��Ҷ֧��㹤��� BankAccount ��Ф��ʷ���׺�ʹ���ҹ�� (�ʹ�Թ��������´��͹)
    protected float _balance;

    // internal: ��Ҷ֧��੾��� Assembly ���ǡѹ (��Ҥ�����ǡѹ) �� �������Ң�
    internal string BranchId { get; set; }

    // private: ��Ҷ֧��੾��㹤��� BankAccount ��ҹ�� (���ʼ�ҹ����Ӥѭ)
    private string _passwordHash;

    // Constructor �ͧ Base Class
    public BankAccount(string accountNumber, string passwordHash, float initialBalance, string branchId)
    {
        AccountNumber = accountNumber;
        _passwordHash = passwordHash;
        _balance = initialBalance;
        BranchId = branchId;
        Debug.Log($"Account {AccountNumber} has been created.");
    }

    // public: ���ʹ����Ѻ�ҡ�Թ (�ء����ͧ����)
    public void Deposit(float amount)
    {
        if (amount > 0)
        {
            _balance += amount; // ����ö��Ҷ֧ protected field ��
            Debug.Log($"Deposited {amount:C}. New balance: {_balance:C}");
        }
    }

    // protected: ���ʹ����Ѻ�͹�Թ (������������١���¡��)
    protected bool Withdraw(float amount)
    {
        if (amount > 0 && _balance >= amount)
        {
            _balance -= amount;
            Debug.Log($"Withdrew {amount:C}. New balance: {_balance:C}");
            return true;
        }
        Debug.Log("Insufficient funds or invalid amount.");
        return false;
    }

    //4. private: ���ʹ����Ѻ��Ǩ�ͺ���ʼ�ҹ
    // ����������� (Encapsulation)
    // ���ͻ���ͧ�������Ӥѭ���������Ҷ֧��ҡ��¹͡��º���ʼ�ҹ����Ѻ�ҡѺ���ʼ�ҹ��������
    private bool VerifyPassword(string password)
    {
        // 㹤����繨�ԧ���ա�� Hash password
        return password == _passwordHash;
    }

    //5. public: ���ʹ��������¡ private method �ҡ��¹͡
    // ����������� (Encapsulation)
    // ���ͻ���ͧ�������Ӥѭ���������§������ʼ�ҹ�١��ͧ�������
    public bool CheckPassword(string password)
    {
        return VerifyPassword(password);
    }
}
