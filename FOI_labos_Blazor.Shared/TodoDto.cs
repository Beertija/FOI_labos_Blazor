﻿namespace FOI_labos_Blazor.Shared;

public class TodoDto
{
    public Guid Id { get; set; }
    public string Title { get; set; }
    public bool IsCompleted { get; set; } = false;
}