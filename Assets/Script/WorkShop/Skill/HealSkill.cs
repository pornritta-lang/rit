using System;
using UnityEngine;

[CreateAssetMenu(fileName = "HealSkill", menuName = "Skills/HealSkill")]
public class HealSkill : Skill
{
    public int healingAmountPerSecond = 5;

    // ���������Ѻ�纤�Ҿ�ѧ���Ե����ͧ��鹿�����
    private float healAccumulator = 0f;
    public HealSkill()
    {
        this.skillName = "Heal";
        this.cooldownTime = 8;
        this.Duration = 5f; // �������ҷ��ʡ���ռ�
    }

    public float Duration { get; set; }

    // ��ͧ Override ���ʹ Activate()
    public override void Activate(Character character)
    {
        Debug.Log("Casting Heal Over Time!");
        timer = Duration;

        // �鴷����㹡�ÿ�鹿٤�Ҿ�ѧ���Ե
    }

    public override void Deactivate(Character character)
    {
        Debug.Log("Heal skill duration ended.");
    }

    public override void UpdateSkill(Character character)
    {
        timer -= Time.deltaTime;
        if (timer > 0)
        {
            // ������Ҿ�ѧ���Ե����ͧ��鹿�
            healAccumulator += Time.deltaTime;

            // ��Ҥ�������֧ 1 �����ҡ���� ���ӡ�ÿ�鹿�����ѡ��ҷ������͡
            if (healAccumulator >= 1)
            {
                character.Heal(healingAmountPerSecond);
                healAccumulator = 0;
                Debug.Log($"{character.Name} heals for {healingAmountPerSecond} HP. Remaining Duration: {timer:F2} seconds.");
            }
        }
        else
        {
            // ����������������ŧ
            Deactivate(character);
        }
    }
}
