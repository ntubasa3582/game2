using UnityEngine;

/// <summary>
/// 得点のためのコインアイテムのコンポーネント
/// </summary>
public class IdouUp: Item  // ItemBase2D を継承している
{

    public override void Activate()
    {
        FindObjectOfType<Move>()._moveSpeed = 20;
    }
}
