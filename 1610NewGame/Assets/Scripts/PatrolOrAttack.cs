using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.Purchasing;
using UnityEngine;
using UnityScript.Steps;

public class PatrolOrAttack : MonoBehaviour
{
   public Transform playerOne;
   public Transform playerLure;
   public Transform[] patrolPoints;
   private UnityEngine.AI.NavMeshAgent enemyAgent;
   private int currentPatrolPoint = 0;

   public float patrolSpeed = 3.5f;
   public float attackSpeed = 8f;

   private Action CanPatrol;
   private Action CanChase;
   private Action CanAttack;
   

   void Patrolling()
   {
      if (patrolPoints.Length == 0)
         return;
      enemyAgent.destination = patrolPoints[currentPatrolPoint].position;

      currentPatrolPoint = (currentPatrolPoint + 1) % patrolPoints.Length;
      
   }


   public void StopPatrolling()
   {
      CanPatrol -= Patrolling;
      CanChase += Chasing;
      enemyAgent.speed = attackSpeed;
      
   }

   public void StopChasing()
   {
      CanChase -= Chasing;
      CanAttack += Attacking;
      
   }

   void Chasing()
   {
      print("chasing"+this.name);
      enemyAgent.destination = playerLure.position;
   }

   void Attacking()
   {
      print("attacking"+this.name);
      enemyAgent.destination = playerOne.position;
   }

   void Update()
   {
      if (enemyAgent.remainingDistance < 0.5f)
      {
         if (CanPatrol != null)
            CanPatrol();
      }

      if (CanChase != null)
         CanChase();

      if (CanAttack != null)
         CanAttack();
      
   }


   void Start()
   {
      enemyAgent = GetComponent<UnityEngine.AI.NavMeshAgent>();
      CanPatrol += Patrolling;
      enemyAgent.speed = patrolSpeed;
   }

}
