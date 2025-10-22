// Copyright (c) Microsoft Corporation.
// Licensed under the MIT License.

using Azure.Mcp.Core.Areas;
using Azure.Mcp.Core.Commands;
using Azure.Mcp.Tools.FoundryBestPractices.Commands;
using Microsoft.Extensions.DependencyInjection;

namespace Azure.Mcp.Tools.FoundryBestPractices;

public class FoundryBestPracticesSetup : IAreaSetup
{
    public string Name => "azureagent";

    public void ConfigureServices(IServiceCollection services)
    {
        services.AddSingleton<FoundryBestPracticesGetCommand>();
    }

    public CommandGroup RegisterCommands(IServiceProvider serviceProvider)
    {
        // Register Azure Agent Code Generation Best Practices command at the root level
        var azureAgentBestPractices = new CommandGroup(
            Name,
            @"Returns best practices for building AI agents and applications in Azure. Call this before 
            generating code for AI agents, building applications with Azure AI Foundry models, or working with 
            Azure AI resources. Includes guidance on Microsoft Agent Framework, model selection, and implementation patterns. 
            If this tool needs to be categorized, it belongs to the Azure Best Practices category."
        );

        var practices = serviceProvider.GetRequiredService<FoundryBestPracticesGetCommand>();
        azureAgentBestPractices.AddCommand(practices.Name, practices);

        return azureAgentBestPractices;
    }
}
