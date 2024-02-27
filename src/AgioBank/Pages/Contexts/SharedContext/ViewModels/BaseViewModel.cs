using AgioBank.Pages.Contexts.SharedContext.Enums;
using MediatR;
using Microsoft.AspNetCore.Components;
using Response = AgioBank.Contexts.SharedContext.Response;

namespace AgioBank.Pages.Contexts.SharedContext.ViewModels
{
    public abstract class BaseViewModel : ComponentBase
    {
        public EState PageState { get; set; } = EState.Idle;

        public ResultViewModel? Success { get; set; } = null;

        public ResultViewModel? Error { get; set; } = null;

        public async Task OnValidSubmitAsync<TRequest, TResponse>(
            TRequest request,
            IRequestHandler<TRequest, TResponse> handler)
            where TRequest: IRequest<TResponse>
            where TResponse: Response
        {
            PageState = EState.Busy;

            try
            {
                var response = await handler.Handle(request, new CancellationToken());
                SetState(response);
            }
            catch (Exception ex)
            {
                Error = new ResultViewModel(ex.Message);
                PageState = EState.Error;
            }
        }

        private void SetState(
            Response response,
            string ?redirectUrl = null)
        {
            switch (response.IsSuccess) 
            { 
                case true:
                    PageState = EState.Success;
                    Success = new ResultViewModel(response.Message);
                    Error = null;
                    return;

                case false:
                    PageState = EState.Error;
                    Error = new ResultViewModel(response.Message, null , redirectUrl);
                    Success = null;
                    return;
            }
        }

    }
}
