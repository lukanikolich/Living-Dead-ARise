using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieMovement : MonoBehaviour
{
    private float walkSpeed = 0.3f;
    private float runSpeed = 2f;

    private Camera camera;
    private Animator animator;

    private AnimatorClipInfo[] m_CurrentClipInfo;
    string m_ClipName;

    private string[] movementAnimatons = { "walk01", "walk02", "walk03", "run" };

    // Start is called before the first frame update
    void Start()
    {
        camera = GameObject.FindWithTag("MainCamera").GetComponent<Camera>();
        animator = GetComponent<Animator>();

        // set random movement
        string chosenAnimation = movementAnimatons[Random.Range(0, movementAnimatons.Length)];
        animator.SetBool(chosenAnimation, true);
    }

    // Update is called once per frame
    void Update()
    {
        m_CurrentClipInfo = this.animator.GetCurrentAnimatorClipInfo(0);
        m_ClipName = m_CurrentClipInfo[0].clip.name;

        if (m_ClipName.Equals("run"))
        {
            transform.position += transform.forward * Time.deltaTime * runSpeed;
        }
        else if (m_ClipName.Equals("walk01") || m_ClipName.Equals("walk02") || m_ClipName.Equals("walk03"))
        {
            transform.position += transform.forward * Time.deltaTime * walkSpeed;
        }
        transform.LookAt(new Vector3(camera.transform.position.x, transform.position.y, camera.transform.position.z));
    }
}
