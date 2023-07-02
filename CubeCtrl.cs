using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CubeCtrl : MonoBehaviour
{
    // Start is called before the first frame update
    /// <summary>
    /// 移动的目标点
    /// </summary>
    private Vector3 m_targetPos = Vector3.zero;
    /// <summary>
    /// 控制器
    /// </summary>
    private CharacterController m_characterController;
    /// <summary>
    /// 移动速度
    /// </summary>
    [SerializeField]
    private float m_speed = 10f;
    void Start()
    {
        m_characterController = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (m_characterController == null) return;
        if (Input.GetMouseButtonUp(0)) 
        {
            //射线
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hitInfo;
            if (Physics.Raycast(ray, out hitInfo)) 
            {
                if (hitInfo.collider.gameObject.name.Equals("Ground", System.StringComparison.CurrentCultureIgnoreCase)) 
                {
                    m_targetPos = hitInfo.point;       
                }
            }
        }
        //如果目标点不是原点
        if (m_targetPos != Vector3.zero)
        {
            //Debug.DrawLine(Camera.main.transform.position, m_targetPos);
            if (Vector3.Distance(m_targetPos, transform.position) > 0.1f)
            {
                Vector3 direcition = m_targetPos - transform.position;
                direcition = direcition.normalized;
                direcition = direcition * Time.deltaTime * m_speed;
                m_characterController.Move(direcition);
                
            }

        }
    }
}
