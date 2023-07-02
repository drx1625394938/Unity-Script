using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CubeCtrl : MonoBehaviour
{
    // Start is called before the first frame update
    /// <summary>
    /// �ƶ���Ŀ���
    /// </summary>
    private Vector3 m_targetPos = Vector3.zero;
    /// <summary>
    /// ������
    /// </summary>
    private CharacterController m_characterController;
    /// <summary>
    /// �ƶ��ٶ�
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
            //����
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
        //���Ŀ��㲻��ԭ��
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
