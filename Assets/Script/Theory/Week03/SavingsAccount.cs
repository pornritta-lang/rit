using System;
using UnityEngine;

public class SavingsAccount : BankAccount
{
    // public: �ѵ�Ҵ͡����
    public float InterestRate { get; set; }

    // Constructor �ͧ SavingsAccount
    public SavingsAccount(string accountNumber, string passwordHash, float initialBalance, string branchId, float interestRate)
        : base(accountNumber, passwordHash, initialBalance, branchId)
    {
        InterestRate = interestRate;
        Debug.Log($"Savings account {AccountNumber} created with interest rate {InterestRate:P}.");
    }

    //9. public: ���ʹ����Ѻ�͹�Թ���١�Ǻ���
    //����������� (Encapsulation) �µ�Ǩ�ͺ���ʼ�ҹ��͹
    //���ͺ�����Ҷ֧ protected method �ҡ�����١
    public void WithdrawFunds(float amount, string password)
    {
        if (CheckPassword(password))
        {
            // ���¡�� protected method �ͧ Base Class ��
            Withdraw(amount);
        }
        else
        {
            Debug.Log("Incorrect password. Withdrawal failed.");
        }
    }

    //8. public: ���ʹ੾�Тͧ SavingsAccount
    //���ͺ�����Ҷ֧ protected field �ҡ�����١
    public void AddMonthlyInterest()
    {
        float interest = _balance * InterestRate;
        _balance += interest; // ����ö��Ҷ֧ protected field ��
        Debug.Log($"Added monthly interest of {interest:C}. New balance: {_balance:C}");
    }
}
