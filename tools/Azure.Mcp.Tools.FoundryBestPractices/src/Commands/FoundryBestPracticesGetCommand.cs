// Copyright (c) Microsoft Corporation.
// Licensed under the MIT License.

using System.Net;
using System.Reflection;
using Azure.Mcp.Core.Commands;
using Azure.Mcp.Core.Helpers;
using Microsoft.Extensions.Logging;

namespace Azure.Mcp.Tools.FoundryBestPractices.Commands;

public sealed class FoundryBestPracticesGetCommand(ILogger<FoundryBestPracticesGetCommand> logger) : BaseCommand<EmptyOptions>
{
    private const string CommandTitle = "Get Azure Agent Code Generation Best Practices";
    private readonly ILogger<FoundryBestPracticesGetCommand> _logger = logger;
    private static readonly string s_bestPracticesText = LoadBestPracticesText();

    private static string GetBestPracticesText() => s_bestPracticesText;

    private static string LoadBestPracticesText()
    {
        Assembly assembly = typeof(FoundryBestPracticesGetCommand).Assembly;
        string resourceName = EmbeddedResourceHelper.FindEmbeddedResource(assembly, "azure-agent-codegen-best-practices.txt");
        return EmbeddedResourceHelper.ReadEmbeddedResource(assembly, resourceName);
    }

    public override string Name => "get";

    public override string Description =>
        @"Returns best practices for building AI agents and applications using Azure AI services including Azure OpenAI and Azure AI Foundry. 
        Call this command and follow its guidance before generating or suggesting any code for Azure AI agents, building applications with 
        Azure OpenAI or Azure AI Foundry models, or working with Azure AI resources. Includes guidance on SDK selection 
        (Microsoft Agent Framework), model selection, resource preparation, and implementation patterns. If this tool 
        needs to be categorized, it belongs to the Azure Best Practices category.";

    public override string Title => CommandTitle;

    public override ToolMetadata Metadata => new()
    {
        Destructive = false,
        Idempotent = true,
        OpenWorld = false,
        ReadOnly = true,
        LocalRequired = false,
        Secret = false
    };

    protected override EmptyOptions BindOptions(ParseResult parseResult) => new();

    public override Task<CommandResponse> ExecuteAsync(CommandContext context, ParseResult parseResult)
    {
        var bestPractices = GetBestPracticesText();

        context.Response.Status = HttpStatusCode.OK;
        context.Response.Results = ResponseResult.Create([bestPractices], FoundryBestPracticesJsonContext.Default.ListString);

        return Task.FromResult(context.Response);
    }
}
