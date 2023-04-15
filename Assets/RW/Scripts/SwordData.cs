using Unity.VisualScripting;
using UnityEngine;

[CreateAssetMenu(fileName = "New SwordData", menuName = "Sword Data", order = 51)]
public class SwordData : ScriptableObject
{
    [SerializeField] private string swordName;

    [SerializeField] private string swordDescription;

    [SerializeField] private Sprite Icon;

    [SerializeField] private int goldCost;

    [SerializeField] private int attackDamage;


    public string SwordName
    {
        get
        {
            return swordName;
        }
    }

    public string Description
    {
        get
        {
            return swordDescription;
        }
    }

    public Sprite GetIcon()
    {
        return Icon;
    }

    public int GoldCost
    {
        get
        {
            return goldCost;
        }
    }

    public int AttackDamage
    {
        get
        {
            return attackDamage;
        }
    }


}
