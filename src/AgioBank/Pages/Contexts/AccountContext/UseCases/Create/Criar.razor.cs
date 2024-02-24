using AgioBank.Contexts.AccountContext.Entities;
using AgioBank.Contexts.AccountContext.UseCases.Create;
using AgioBank.Pages.Contexts.SharedContext.Enums;
using AgioBank.Pages.Contexts.SharedContext.ViewModels;
using MediatR;
using Microsoft.AspNetCore.Components;
using System.ComponentModel.DataAnnotations;

namespace AgioBank.Pages.Contexts.AccountContext.UseCases.Create
{
    public class ViewModel : BaseViewModel
    {
        [Inject]
        private IMediator? mediator { get; set; }

        private Conta? _conta;

        public InputViewModel _model { get; set; } = new();
        public EState PageState { get; set; } = EState.Idle;
        protected override Task OnInitializedAsync()
        {
            return base.OnInitializedAsync();
        }
        public async Task OnValidSubmitAsync()
        {
            _conta = new();
            PageState = EState.Busy;
            var response = await mediator!.Send(new
            Request ( 
             _model.Nome,
             _model.Sobrenome,
             _model.Email,
             _model.Telefone,
             _model.Documento,
             _model.NomeMae
            )
            , new CancellationToken());
            PageState = EState.Success;
        }
    }
}
