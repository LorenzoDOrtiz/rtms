﻿using RTMS.UseCases.PluginInterfaces;
using RTMS.UseCases.Workouts.Interfaces;

namespace RTMS.UseCases.ActiveWorkouts;

public class ViewActiveWorkoutByIdUseCase : IViewActiveWorkoutByIdUseCase
{
    private readonly IWorkoutRepository _workoutRepository;

    public ViewActiveWorkoutByIdUseCase(IWorkoutRepository workoutRepository)
    {
        _workoutRepository = workoutRepository;
    }

    public async Task ExecuteAsync(int workoutId)
    {
        await _workoutRepository.GetWorkoutByIdAsync(workoutId);
    }
}
