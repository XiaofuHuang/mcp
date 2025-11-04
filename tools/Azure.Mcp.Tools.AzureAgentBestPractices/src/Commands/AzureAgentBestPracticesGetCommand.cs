// Copyright (c) Microsoft Corporation.
// Licensed under the MIT License.

using System.Net;
using System.Reflection;
using Azure.Mcp.Core.Commands;
using Azure.Mcp.Core.Helpers;
using Microsoft.Extensions.Logging;

namespace Azure.Mcp.Tools.AzureAgentBestPractices.Commands;

public sealed class AzureAgentBestPracticesGetCommand(ILogger<AzureAgentBestPracticesGetCommand> logger) : BaseCommand<EmptyOptions>
{
    private const string CommandTitle = "Get Agent Best Practices for Azure";
    private readonly ILogger<AzureAgentBestPracticesGetCommand> _logger = logger;
    private static readonly string s_bestPracticesText = LoadBestPracticesText();

    private static string GetBestPracticesText() => s_bestPracticesText;

    private static string LoadBestPracticesText()
    {
        Assembly assembly = typeof(AzureAgentBestPracticesGetCommand).Assembly;
        string resourceName = EmbeddedResourceHelper.FindEmbeddedResource(assembly, "agent-best-practices-for-azure.txt");
        return EmbeddedResourceHelper.ReadEmbeddedResource(assembly, resourceName);
    }

    public override string Id => "6c29659e-406d-4b9b-8150-e3d4fd7ba31c";

    public override string Name => "get";

    public override string Description =>
        @"Returns best practices for building AI applications, workflows and agents in Azure. Call this before 
        generating code for any AI application, building with Azure AI Foundry models, working with 
        Microsoft Agent Framework, or implementing AI solutions in Azure. Includes guidance on Microsoft 
        Agent Framework, model selection, SDK recommendations, and implementation patterns for all Azure AI scenarios.
        If this tool needs to be categorized, it belongs to the Azure Best Practices category.";

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
        try
        {
            var bestPractices = GetBestPracticesText();
            context.Response.Status = HttpStatusCode.OK;
            context.Response.Results = ResponseResult.Create([bestPractices], AzureAgentBestPracticesJsonContext.Default.ListString);
            context.Response.Message = string.Empty;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error getting agent best practices for Azure");
            HandleException(context, ex);
        }

        return Task.FromResult(context.Response);
    }
}
