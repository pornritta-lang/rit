using UnityEngine;
using TMPro;
public interface IInteractable
{
    // �س���ѵ�����Ѻ�����ѵ��
    bool isInteractable { get; set; }
    // ���ʹ����ͧ�������ͧ�Ѻ�����ͺ
    void Interact(Player player);


}
