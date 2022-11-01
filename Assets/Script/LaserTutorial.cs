using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserTutorial : MonoBehaviour
{
    [SerializeField] private float defDistanceRay = 100;
    [SerializeField] private Transform LaserFirePoint;
    [SerializeField] private LineRenderer m_LineRenderer;
    [SerializeField] private Transform m_transform;
    // Start is called before the first frame update
     void Awake()
    {
        m_transform = GetComponent<Transform>();
    }

    private void update()
    {
        ShootLaser();
    }
    void ShootLaser()
    {
        if (Physics2D.Raycast(m_transform.position, m_transform.right))
        {
            RaycastHit2D _hit = Physics2D.Raycast(LaserFirePoint.position, m_transform.right);
            Draw2DRay(LaserFirePoint.position, _hit.point);
        }

        else
        {
            Draw2DRay(LaserFirePoint.position, LaserFirePoint.transform.right * defDistanceRay);
        }
    }
    
    void Draw2DRay(Vector2 startpos, Vector2 endpose)
    {
        m_LineRenderer.SetPosition(0, startpos);
        m_LineRenderer.SetPosition(1, endpose);
    }
      
    
}
