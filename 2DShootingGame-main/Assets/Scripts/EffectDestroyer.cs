using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// ��ǥ: ����Ʈ�� ��ƼŬ ȿ���� ����Ǹ� �� �����θ� �ı��Ѵ�.
// �Ӽ�: ��ƼŬ�ý���
public class Effect : MonoBehaviour
{
    // �Ӽ�: ��ƼŬ�ý���
    ParticleSystem rootParticleSystem;

    private void Start()
    {
        rootParticleSystem = this.GetComponentInChildren<ParticleSystem>();
    }

    // Start is called before the first frame update
    void Update()
    {
        // ��ǥ: ����Ʈ�� ��ƼŬ ȿ���� ����Ǹ� �� �����θ� �ı��Ѵ�.
        if (!rootParticleSystem.IsAlive(true))
        {
            GameObject.Destroy(this.gameObject);
        }
    }
}
