using System;
using System.IO;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.AI;

#if UNITY_EDITOR
using UnityEditor;
using UnityEditorInternal;
#endif

using Object = UnityEngine.Object;
using Random = UnityEngine.Random;

namespace Game
{
    [RequireComponent(typeof(NavMeshAgent))]
	public class Character : MonoBehaviour
	{
        NavMeshAgent agent;

        Animator animator;

        void Awake()
        {
            agent = GetComponent<NavMeshAgent>();

            animator = GetComponentInChildren<Animator>();
            animator.applyRootMotion = false;
        }

		public void MoveTo(Vector3 position)
        {
            agent.SetDestination(position);
        }

        void Update()
        {
            animator.SetFloat("Speed", agent.velocity.magnitude);
        }
	}
}