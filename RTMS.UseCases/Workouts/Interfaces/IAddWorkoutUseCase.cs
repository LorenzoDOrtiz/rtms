﻿using RTMS.CoreBusiness;

namespace RTMS.UseCases.Workouts.Interfaces;
public interface IAddWorkoutUseCase
{
    Task ExecuteAsync(WorkoutTemplate workoutTemplate);
}