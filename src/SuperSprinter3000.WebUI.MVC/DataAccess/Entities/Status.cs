﻿using System.ComponentModel.DataAnnotations;

namespace SuperSprinter3000.WebUI.MVC.DataAccess.Entities;

public enum Status
{
    [Display(Name="Planning")]
    Planning,
    [Display(Name="To Do")]
    Todo,
    [Display(Name="In Progress")]
    InProgress,
    [Display(Name="Review")]
    Review,
    [Display(Name="Done")]
    Done
}