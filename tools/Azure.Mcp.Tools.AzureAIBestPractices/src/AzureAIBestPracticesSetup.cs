// Copyright (c) Microsoft Corporation.
// Licensed under the MIT License.

using Azure.Mcp.Core.Areas;
using Azure.Mcp.Core.Commands;
using Azure.Mcp.Tools.AzureAIBestPractices.Commands;
using Microsoft.Extensions.DependencyInjection;

namespace Azure.Mcp.Tools.AzureAIBestPractices;

public class AzureAIBestPracticesSetup : IAreaSetup
{
    public string Name => "azureaibestpractices";

    public string Title => "Azure AI Code Generation Best Practices";

    public void ConfigureServices(IServiceCollection services)
    {
        services.AddSingleton<AzureAIBestPracticesGetCommand>();
    }

    public CommandGroup RegisterCommands(IServiceProvider serviceProvider)
    {
        // Register Azure AI Best Practices command at the root level
        var azureAIBestPractices = new CommandGroup(
            Name,
            @"Azure AI best practices - Commands returns best practices and code generation guidance for building AI applications in Azure. 
            Use this tool when you need recommendations on how to write code for AI agents, chatbots, workflows, or other AI features. 
            This tool also provides guidance for code generation using the Azure resources (e.g. Azure AI Foundry) for application development only. 
            For Azure resources (e.g. Azure AI Foundry resource) management operations (e.g., listing/creating/deploying/managing resources like models, agents, deployments, projects, or hubs), use other tools (e.g. 'foundry' tool)  instead.
            If this tool needs to be categorized, it belongs to the Azure Best Practices category.",
            Title
        );

        var practices = serviceProvider.GetRequiredService<AzureAIBestPracticesGetCommand>();
        azureAIBestPractices.AddCommand(practices.Name, practices);

        return azureAIBestPractices;
    }
}
