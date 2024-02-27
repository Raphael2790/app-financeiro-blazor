using AgioBank.Pages.Contexts.SharedContext.Enums;

namespace AgioBank.Pages.Contexts.SharedContext.ViewModels
{
    public class ResultViewModel
    {
        public EState PageState { get; set; } = EState.Idle;
        public string? MainMessage { get; set; }
        public IEnumerable<string>? Messages { get; set; }

        public string? RedirectUrl { get; set; }

        public ResultViewModel(
            string mainMessage,
            IEnumerable<string>? messages = null,
            string? redirectUrl = null
            )
        {
            MainMessage = mainMessage;
            RedirectUrl = redirectUrl;
            if (messages != null && messages.Any()) 
                Messages = messages;                    
        }
    }
}
