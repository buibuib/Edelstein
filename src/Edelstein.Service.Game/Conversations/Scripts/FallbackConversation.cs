using System.Threading.Tasks;

namespace Edelstein.Service.Game.Conversations.Scripts
{
    public class FallbackConversation : IConversation
    {
        public IConversationContext Context { get; }
        public ISpeaker Self { get; }
        public ISpeaker Target { get; }

        private readonly string _script;

        public FallbackConversation(IConversationContext context, ISpeaker self, ISpeaker target, string script)
        {
            Context = context;
            Self = self;
            Target = target;
            _script = script;
        }

        public async Task Start()
        {
            await Self.SayAsync($"The #r{_script}#k script does not exist.");
        }
    }
}