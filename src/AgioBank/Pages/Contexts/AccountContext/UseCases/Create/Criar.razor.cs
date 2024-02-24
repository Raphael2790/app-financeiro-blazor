using AgioBank.Pages.Contexts.SharedContext.Enums;
using AgioBank.Pages.Contexts.SharedContext.ViewModels;

namespace AgioBank.Pages.Contexts.AccountContext.UseCases.Create
{
    public class ViewModel : BaseViewModel
    {
        public InputViewModel _model { get; set; } = new();
        public EState PageState { get; set; } = EState.Idle;
        protected override Task OnInitializedAsync()
        {
            return base.OnInitializedAsync();
        }
        public async Task OnValidSubmitAsync()
        {
            PageState = EState.Busy;
            await Task.Delay(2000);
            PageState = EState.Success;
            await Task.Delay(2000);
            PageState = EState.Idle;
        }
    }
}
