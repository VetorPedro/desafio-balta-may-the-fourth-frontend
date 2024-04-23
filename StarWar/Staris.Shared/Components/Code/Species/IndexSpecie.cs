﻿using Microsoft.AspNetCore.Components;
using Staris.Shared.Services.Interfaces;
using Staris.Shared.ViewModel;

namespace Staris.Shared.Components.Code.Species;

public class IndexSpecie: ComponentBaseGeneric<List<SpecieViewModel>>
{
    [Inject]
    public ISpecieService _service { get; set; } = null!;

    protected override async Task OnInitializedAsync()
    {
        IsDone = false;
        try
        {
            Model = await _service.GetList();
            IsDone = true;
        }
        catch (Exception ex)
        {
            //Apenas para debug
            _ = ex.Message;
        }
    }

}
