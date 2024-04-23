﻿using System.Text.Json.Serialization;

namespace Staris.Shared.ViewModel;

public class StarshipViewModel: ViewModelBase
{
    public string? Name { get; set; }
    public string? Model { get; set; }
    public string? Manufacturer { get; set; }

    [JsonPropertyName("cost_in_credits")]
    public string? CostInCredits { get; set; }
    public string? Length { get; set; }
    /// <summary>
    /// The maximum speed of this starship in the atmosphere.
    /// </summary>
    [JsonPropertyName("max_atmosphering_speed")]
    public string? MaxSpeedAtmosphering { get; set; }
    /// <summary>
    /// The number of personnel needed to run or pilot this starship.
    /// </summary>
    public string? Crew { get; set; }
    public string? Passengers { get; set; }

    /// <summary>
    /// The maximum number of kilograms that this starship can transport.
    /// </summary>
    [JsonPropertyName("cargo_capacity")]
    public string? CargoCapacity { get; set; }

    [JsonPropertyName("hyperdrive_rating")]
    public string? HyperdriveRating { get; set; }

    /// <summary>
    /// Velocity - megalight per hour (abbreviated MGLT) was a unit used to measure the relative sublight speed of starships 
    /// </summary>
    public string? Mglt { get; set; } 
    public string? Consumables { get; set; }

    [JsonPropertyName("starship_class")]
    public string? StarshipClass { get; set; }
    public List<string>? Pilots { get; set; }
    public List<CharacterViewModel>? PilotsVM { get; set; }
    public List<string>? Films { get; set; }
    public List<MovieViewModel>? Movies { get; set; }
}
