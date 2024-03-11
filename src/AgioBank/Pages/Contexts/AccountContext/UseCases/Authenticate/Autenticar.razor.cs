using AgioBank.Pages.Contexts.SharedContext.ViewModels;
using Microsoft.AspNetCore.Components;
using UseCase = AgioBank.Contexts.AccountContext.UseCases.Authenticate;

namespace AgioBank.Pages.Contexts.AccountContext.UseCases.Authenticate
{
    public class ViewModel : BaseViewModel
    {
        [Inject]
        private UseCase.Handler Handler { get; set; } = null!;

        public InputViewModel Model { get; set; } = new();

        protected async Task OnValidSubmitAsync()
            => await base.OnValidSubmitAsync(Model, Handler);
    }
}
