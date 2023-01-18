using System.Net;
using NUnit.Framework;
using FluentAssertions;
using Microsoft.AspNetCore.Mvc.Testing;

namespace MikroBlogTests;

[TestFixture]
public class AcceptanceTests
{
    [Test]
    public async Task GET_user_posts()
    {
        await using var application = new WebApplicationFactory<Program>();
        using var client = application.CreateClient();
        
        var response = await client.GetAsync("/myuser/posts");
        
        response.StatusCode.Should().Be(HttpStatusCode.OK);
        response.Content.ReadAsStringAsync().Result.Should().Be("hello myuser");
    }
}