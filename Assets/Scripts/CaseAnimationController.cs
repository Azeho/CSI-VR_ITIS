using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CaseAnimationController : MonoBehaviour
{
   private Animator caseAnimator;
   [SerializeField] private GameObject camera;
   [SerializeField] private GameObject torch;
   [SerializeField] private GameObject brush;

   public void Start()
   {
      caseAnimator = GetComponent<Animator>();
   }

   public void ManageCase()
   {
      if (!caseAnimator.GetBool("isOpened"))
         Open();
      else Close();
   }
   
   
   private void Open()
   {
      caseAnimator.SetBool("isOpened", true);
   }

   private void Close()
   {
      caseAnimator.SetBool("isOpened", false);
   }
}
