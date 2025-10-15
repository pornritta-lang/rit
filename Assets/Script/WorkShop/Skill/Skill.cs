using System;
using UnityEngine;

public abstract class Skill
{
    public string skillName;
    public float cooldownTime;
    public float lastUsedTime = float.MinValue; // ��������ش�����ʡ��
    public float timer; // ��ǨѺ��������Ѻʡ�ŷ���ռŵ�����ͧ

    // ���ʹ����� abstract, �ѧ�Ѻ�������١��ͧ implement
    public abstract void Activate(Character character);
    public abstract void Deactivate(Character character);
    public abstract void UpdateSkill(Character character);
    public void ResetCooldown()
    {
        lastUsedTime = float.MinValue; // ��������ش�����ʡ��
    }
    public bool IsReady(float GameTime)
    {
        return GameTime >= lastUsedTime + cooldownTime;
    }

    // ���ʹ����Ѻ�ѹ�֡���ҷ����ʡ��
    public void TimeStampSkill(float GameTime)
    {
        lastUsedTime = GameTime;
    }

    // ���ʹ����ա����ҹ�����ѹ
    public void DisplayInfo()
    {
        Debug.Log($"Skill: {skillName}");
        Debug.Log($"Cooldown: {cooldownTime}s");
    }
}
