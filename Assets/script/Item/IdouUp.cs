using UnityEngine;

/// <summary>
/// ���_�̂��߂̃R�C���A�C�e���̃R���|�[�l���g
/// </summary>
public class IdouUp: Item  // ItemBase2D ���p�����Ă���
{

    public override void Activate()
    {
        FindObjectOfType<Move>()._moveSpeed = 20;
    }
}
