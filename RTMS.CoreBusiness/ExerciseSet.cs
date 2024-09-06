﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RTMS.CoreBusiness;
public class ExerciseSet
{
    [Key]
    public int Id { get; set; }  // Primary key

    [ForeignKey("ExerciseId")]
    public int ExerciseId { get; set; }  // Foreign key to Exercise

    public virtual Exercise Exercise { get; set; }  // Navigation property

    [Required]
    public int Reps { get; set; }  // Number of repetitions

    [Required]
    public double Weight { get; set; }  // Weight lifted
}