using AgioBank.Contexts.AccountContext.Entities;
using AgioBank.Contexts.AccountContext.UseCases.Create;
using AgioBank.Pages.Contexts.SharedContext.Enums;
using AgioBank.Pages.Contexts.SharedContext.ViewModels;
using Microsoft.AspNetCore.Components;
using System.ComponentModel.DataAnnotations;
using UseCase = AgioBank.Contexts.AccountContext.UseCases.Create;

namespace AgioBank.Pages.Contexts.AccountContext.UseCases.Create
{
    public class ViewModel : BaseViewModel
    {
        [Inject]
        private UseCase.Handler Handler { get; set; } = null!;

        public InputViewModel Model { get; set; } = new();
        protected override Task OnInitializedAsync()
        {
            return base.OnInitializedAsync();
        }
        protected async Task OnValidSubmitAsync()
            =>  await base.OnValidSubmitAsync(Model, Handler);
        
    }
}
