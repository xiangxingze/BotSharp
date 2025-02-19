namespace BotSharp.Abstraction.Agents.Enums;

public enum AgentField
{
    All = 1,
    Name,
    Description,
    IsPublic,
    Disabled,
    Type,
    InheritAgentId,
    Profiles,
    RoutingRule,
    Instruction,
    Function,
    Template,
    Response,
    Sample,
    LlmConfig,
    Utility,
    KnowledgeBase,
    EventRule,
    MaxMessageCount
}

public enum AgentTaskField
{
    All = 1,
    Name,
    Description,
    Enabled,
    Content,
    DirectAgentId
}
