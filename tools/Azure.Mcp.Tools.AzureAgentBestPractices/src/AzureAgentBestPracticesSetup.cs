// Copyright (c) Microsoft Corporation.
// Licensed under the MIT License.

using Azure.Mcp.Core.Areas;
using Azure.Mcp.Core.Commands;
using Azure.Mcp.Tools.AzureAgentBestPractices.Commands;
using Microsoft.Extensions.DependencyInjection;

namespace Azure.Mcp.Tools.AzureAgentBestPractices;

public class AzureAgentBestPracticesSetup : IAreaSetup
{
    public string Name => "azureagentbestpractices";

    public string Title => "Azure Agent Code Generation Best Practices";

    public void ConfigureServices(IServiceCollection services)
    {
        services.AddSingleton<AzureAgentBestPracticesGetCommand>();
    }

    public CommandGroup RegisterCommands(IServiceProvider serviceProvider)
    {
        // Register Azure Agent Best Practices command at the root level
        var azureAgentBestPractices = new CommandGroup(
            Name,
            @"Azure agent best practices - Commands returns best practices for building AI applications, workflows and agents in Azure. Call this before 
            generating code for any AI-related task,  AI application, building with Azure AI Foundry models, working with 
            Microsoft Agent Framework, or implementing AI solutions in Azure. Includes guidance on Microsoft 
            Agent Framework, model selection, SDK recommendations, and implementation patterns for all Azure AI scenarios.
            If this tool needs to be categorized, it belongs to the Azure Best Practices category.",
            Title
        );

        var practices = serviceProvider.GetRequiredService<AzureAgentBestPracticesGetCommand>();
        azureAgentBestPractices.AddCommand(practices.Name, practices);

        return azureAgentBestPractices;
    }
}
