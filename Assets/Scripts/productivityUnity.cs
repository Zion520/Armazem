using UnityEngine;

public class productivityUnity : Unit
{  
    //novas variaveis
    private ResourcePile m_currentPile = null;
    public float productivityMultiplier = 2;

   protected override void BuildingInRange()
   {
    if (m_currentPile == null)
    {
        ResourcePile pile = m_Target as ResourcePile;
        if (pile != null)
        {
            m_currentPile = pile;
            m_currentPile.ProductionSpeed += productivityMultiplier;
        }
    }
   }

}
