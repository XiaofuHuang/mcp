// Copyright (c) Microsoft Corporation.
// Licensed under the MIT License.

using System.CommandLine;
using System.Net;
using System.Text.Json;
using Azure.Mcp.Core.Models.Command;
using Azure.Mcp.Tools.FoundryBestPractices.Commands;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using NSubstitute;
using Xunit;

namespace Azure.Mcp.Tools.FoundryBestPractices.UnitTests;

public class FoundryBestPracticesGetCommandTests
{
    private readonly IServiceProvider _serviceProvider;
    private readonly ILogger<FoundryBestPracticesGetCommand> _logger;
    private readonly CommandContext _context;
    private readonly FoundryBestPracticesGetCommand _command;
    private readonly Command _commandDefinition;

    public FoundryBestPracticesGetCommandTests()
    {
        var collection = new ServiceCollection();
        _serviceProvider = collection.BuildServiceProvider();

        _context = new(_serviceProvider);
        _logger = Substitute.For<ILogger<FoundryBestPracticesGetCommand>>();
        _command = new(_logger);
        _commandDefinition = _command.GetCommand();
    }

    [Fact]
    public void Constructor_InitializesCommandCorrectly()
    {
        // Assert
        Assert.NotNull(_command);
        Assert.Equal("get", _command.Name);
        Assert.Equal("Get Azure Agent Code Generation Best Practices", _command.Title);
        Assert.NotNull(_command.Description);
        Assert.Contains("Azure AI", _command.Description);
    }

    [Fact]
    public async Task ExecuteAsync_ReturnsAzureFoundryBestPractices()
    {
        var args = _commandDefinition.Parse([]);
        var response = await _command.ExecuteAsync(_context, args);

        // Assert
        Assert.NotNull(response);
        Assert.Equal(HttpStatusCode.OK, response.Status);
        Assert.NotNull(response.Results);

        var json = JsonSerializer.Serialize(response.Results);
        var result = JsonSerializer.Deserialize<string[]>(json);

        Assert.NotNull(result);
        Assert.Single(result);
        Assert.Contains("Microsoft Agent Framework", result[0]);
        Assert.Contains("Azure AI", result[0]);
        Assert.Contains("agent-framework-azure-ai", result[0]);
    }

    [Fact]
    public async Task ExecuteAsync_DeserializationValidation()
    {
        var args = _commandDefinition.Parse([]);
        var response = await _command.ExecuteAsync(_context, args);

        // Verify we can deserialize the response
        var json = JsonSerializer.Serialize(response.Results);
        var result = JsonSerializer.Deserialize<string[]>(json);

        Assert.NotNull(result);
        Assert.NotEmpty(result);
        Assert.All(result, item => Assert.False(string.IsNullOrWhiteSpace(item)));
    }

    [Fact]
    public void Metadata_ConfiguredCorrectly()
    {
        // Assert
        var metadata = _command.Metadata;
        Assert.False(metadata.Destructive);
        Assert.True(metadata.Idempotent);
        Assert.False(metadata.OpenWorld);
        Assert.True(metadata.ReadOnly);
        Assert.False(metadata.LocalRequired);
        Assert.False(metadata.Secret);
    }

    [Fact]
    public async Task ExecuteAsync_ReturnsSameContentOnMultipleCalls()
    {
        // First call
        var args1 = _commandDefinition.Parse([]);
        var response1 = await _command.ExecuteAsync(_context, args1);
        var json1 = JsonSerializer.Serialize(response1.Results);
        var result1 = JsonSerializer.Deserialize<string[]>(json1);

        // Second call
        var context2 = new CommandContext(_serviceProvider);
        var args2 = _commandDefinition.Parse([]);
        var response2 = await _command.ExecuteAsync(context2, args2);
        var json2 = JsonSerializer.Serialize(response2.Results);
        var result2 = JsonSerializer.Deserialize<string[]>(json2);

        // Assert results are the same (idempotent)
        Assert.Equal(result1![0], result2![0]);
    }
}
