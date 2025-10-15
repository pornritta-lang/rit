using System;
using UnityEngine;

public class BankAccountGenerator : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //1. ���ҧ Object �ͧ�ѭ�ո�Ҥ�÷���� (Base Class)
        BankAccount generalAccount = new BankAccount("B-67890", "general_pass", 500, "MainBranch");
        generalAccount.AccountNumber = "B-67890"; // public: ����ö��Ҷ֧��
        generalAccount.BranchId = "NewBranch"; // internal: ����ö��Ҷ֧����������� Assembly ���ǡѹ
        generalAccount.Deposit(200); // public: ����ö��Ҷ֧�� �ҡ�Թ��

        //2. �ͧ��Ҷ֧��Ŵ�������ʹ����ա�á�˹��дѺ�����Ҷ֧��ҧ�
        // generalAccount._balance = 1000; // protected: �������ö��Ҷ֧��ҡ��¹͡
        // generalAccount.Withdraw(100); // protected: �������ö��Ҷ֧��ҡ��¹͡
        // generalAccount._passwordHash = "new_pass"; // private: �������ö��Ҷ֧��ҡ��¹͡
        // generalAccount.VerifyPassword("password"); // private: �������ö��Ҷ֧��ҡ��¹͡

        //3. ���¡���ʹ����������������Ҩ���Ҷ֧���ʼ�ҹ�����ҧ��
        generalAccount.CheckPassword("general_pass"); // public: ����ö��Ҷ֧��͸Ժ�·��������ԸդԴ



        //6. ���ҧ Object �ͧ�ѭ�������Ѿ��
        SavingsAccount myAccount = new SavingsAccount("S-12345", "my_secret_pass", 1000, "SecondaryBranch", 0.05f);
        Debug.Log($"Account Number: {myAccount.AccountNumber}");// public: ����ö��Ҷ֧��
        Debug.Log($"Branch ID: {myAccount.BranchId}");// internal: ����ö��Ҷ֧����������� Assembly ���ǡѹ
        myAccount.Deposit(500);// public: ����ö��Ҷ֧�� �ҡ�Թ��

        //7. �ͧ��Ҷ֧��Ŵ�������ʹ����ա�á�˹��дѺ�����Ҷ֧��ҧ�
        // protected: �������ö��Ҷ֧��ҡ��¹͡
        // myAccount._balance = 2000; // ERROR!
        // myAccount.Withdraw(100); // ERROR!

        // private: �������ö��Ҷ֧��ҡ��¹͡
        // myAccount._passwordHash = "new_pass"; // ERROR!
        // myAccount.VerifyPassword("password"); // ERROR!

        //10. ���¡���ʹ��������������
        myAccount.WithdrawFunds(200f, "my_secret_pass");
        myAccount.WithdrawFunds(50f, "wrong_pass");

        myAccount.AddMonthlyInterest();
    }


}
