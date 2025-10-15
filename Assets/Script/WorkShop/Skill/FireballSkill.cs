using System;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "FireballSkill", menuName = "Skills/FireballSkill")]
public class FireballSkill : Skill
{
    public float searchRadius = 5;

    // ��ͧ Override ���ʹ Activate() ������ Abstract Class ��˹�
    public FireballSkill()
    {
        this.skillName = "FireballSkill";
        this.cooldownTime = 5;
    }
    public override void Activate(Character character)
    {
        Debug.Log(character.Name +" Casting Fireball! Deals 50 damage.");

        Enemy[] target = GetEnemysInRange(character);
        if (target.Length>0)
        {
            foreach (var enemy in target)
            {
                enemy.TakeDamage(50);
                Debug.Log($"{character.Name} casts {skillName} on {enemy.Name}, dealing 50 damage!");

            }
        }
        else
        {
            Debug.Log("No enemies in range to target with Fireball.");
        }
        // �鴷����㹡�����ҧ�١���Фӹǳ�����������
    }

    public override void Deactivate(Character character)
    {
        //��ͧ Override ���ʹ Deactivate() ������ Abstract Class ��˹�����������
    }

    public override void UpdateSkill(Character character)
    {
        //��ͧ Override ���ʹ UpdateSkill() ������ Abstract Class ��˹�����������
    }

    // A private helper method to find the nearest enemy
    private Enemy[] GetEnemysInRange(Character caster)
    {
        // Find all colliders within the search radius
        Collider[] hitColliders = Physics.OverlapSphere(caster.transform.position, searchRadius);
        List<Enemy> Enemys = new List<Enemy>();

        foreach (var hitCollider in hitColliders)
        {
            // Check if the collider belongs to a character that isn't the caster
            Enemy targetCharacter = hitCollider.GetComponent<Enemy>();
            if (targetCharacter != null && targetCharacter != caster)
            {
                Enemys.Add(targetCharacter);
            }
        }
        return Enemys.ToArray();
    }
}
