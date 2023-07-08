using UnityEngine;

/// <summary>
/// 得点のためのコインアイテムのコンポーネント
/// </summary>
public class IdouDown: Item  // ItemBase2D を継承している
{

    public override void Activate()
    {
        FindObjectOfType<Move>()._moveSpeed = 5;
    }
}
